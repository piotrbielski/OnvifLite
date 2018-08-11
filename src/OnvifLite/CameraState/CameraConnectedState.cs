using System;
using System.Collections.Generic;
using System.Text;
using CameraMediaService;
using OnvifLite.Exceptions;
using System.Linq;
using OnvifLite.Attributes;
using System.Collections.Concurrent;
//using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using OnvifLite.Proxy;

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.Connected)]
    internal class CameraConnectedState : ICameraState
    {
        private readonly Camera _camera;
        private BlockingCollection<Bitmap> _frameQueue;

        private readonly CancellationTokenSource _tokenSource;
        private readonly CancellationToken _cancellationToken;

        public CameraConnectedState(Camera camera)
        {
            _camera = camera;
            _frameQueue = new BlockingCollection<Bitmap>(new ConcurrentQueue<Bitmap>(), 100);

            _tokenSource = new CancellationTokenSource();
            _cancellationToken = _tokenSource.Token;
        }

        private void FrameProducer(string url)
        {
            var capture = new VideoCapture(url);
            
            try
            {
                while (true)
                {
                    var frame = capture.QueryFrame();

                    if (frame != null)
                    {
                        var b = frame.ToImage<Bgr, Byte>();
                        Bitmap bb = b.ToBitmap();
                    }
                    else
                    {
                        //todo exception
                    }

                    _cancellationToken.ThrowIfCancellationRequested();
                }
            }
            catch (OperationCanceledException)
            {
                capture.Dispose();
            }
        }

        public void Connect()
        {
            throw new IncorrectCameraStateException("Camera has already been connected.");
        }

        public void Disconnect()
        {
            _camera.StateObject = new CameraNotConnectedState(_camera);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile)
        {
            var proxyFactory = new ProxyFactory<Media, MediaClient>();
            var mediaClient = proxyFactory.CreateProxy(_camera.ServiceAddress);

            StreamSetup streamSetup = new StreamSetup();
            streamSetup.Stream = StreamType.RTPUnicast;

            streamSetup.Transport = new Transport();
            streamSetup.Transport.Protocol = TransportProtocol.RTSP;

            var streamingUrl = mediaClient.GetStreamUriAsync(streamSetup, profile.token).Result;
            var urlParts = streamingUrl.Uri.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            var url = string.Empty;

            mediaClient.Close();

            if (urlParts.Count() == 2)
            {
                url = $"{urlParts[0]}//{_camera.ConnectionUser.Login}:{_camera.ConnectionUser.Password}@{urlParts[1]}";
            }
            else
            {
                //todo exception
            }

            Task.Factory.StartNew(() => FrameProducer(url));

            _camera.StateObject = new CameraStreamingState(_camera, _tokenSource);

            return _frameQueue;
        }

        public void StopStreaming()
        {
            throw new IncorrectCameraStateException("First you need to start streaming.");
        }
    }
}

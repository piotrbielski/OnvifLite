using System;
using OnvifLite.Exceptions;
using System.Linq;
using OnvifLite.Attributes;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using OnvifLite.Proxy;
using OnvifLite.CameraMediaService;

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.Connected)]
    internal class CameraConnectedState : ICameraState
    {
        private readonly Camera _camera;
        private readonly IProxyFactory _proxyFactory;

        private BlockingCollection<Bitmap> _frameQueue;

        private readonly CancellationTokenSource _tokenSource;
        private readonly CancellationToken _cancellationToken;

        public CameraConnectedState(Camera camera, IProxyFactory proxyFactory)
        {
            _camera = camera;
            _proxyFactory = proxyFactory;

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
                        _frameQueue.Add(b.ToBitmap());
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
            _camera.StateObject = new CameraNotConnectedState(_camera, _proxyFactory);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile, int maxCollectionSize)
        {
            _frameQueue = new BlockingCollection<Bitmap>(new ConcurrentQueue<Bitmap>(), maxCollectionSize);

            MediaUri streamingUrl = null;
            string[] uriParts = null;
            var uri = string.Empty;
            
            using (var mediaClient = _proxyFactory.Create<Media, MediaClient>(_camera.ServiceAddress))
            {
                StreamSetup streamSetup = new StreamSetup();
                streamSetup.Stream = StreamType.RTPUnicast;

                streamSetup.Transport = new Transport();
                streamSetup.Transport.Protocol = TransportProtocol.RTSP;

                streamingUrl = mediaClient.GetStreamUriAsync(streamSetup, profile.token).Result;
                uriParts = streamingUrl.Uri.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);                
            }

            if (uriParts != null && uriParts.Count() == 2)
            {
                uri = $"{uriParts[0]}//{_camera.ConnectionUser.Login}:{_camera.ConnectionUser.Password}@{uriParts[1]}";
            }
            else
            {
                throw new InvalidUriAddressException($"Stream URI address is incorrect ({streamingUrl.Uri}).");
            }

            Task.Factory.StartNew(() => FrameProducer(uri));

            _camera.StateObject = new CameraStreamingState(_camera, _proxyFactory, _tokenSource);

            return _frameQueue;
        }

        public void StopStreaming()
        {
            throw new IncorrectCameraStateException("First you need to start streaming.");
        }
    }
}

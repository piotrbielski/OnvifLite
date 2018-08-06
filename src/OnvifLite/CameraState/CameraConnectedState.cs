using System;
using System.Collections.Generic;
using System.Text;
using CameraMediaService;
using OnvifLite.Camera;
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

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.Connected)]
    internal class CameraConnectedState : ICameraState
    {
        private readonly Camera.Camera _camera;
        private BlockingCollection<Bitmap> _frameQueue;

        private readonly CancellationTokenSource _tokenSource;
        private readonly CancellationToken _cancellationToken;

        public CameraConnectedState(Camera.Camera camera)
        {
            _camera = camera;
            _frameQueue = new BlockingCollection<Bitmap>(new ConcurrentQueue<Bitmap>(), 100);

            _tokenSource = new CancellationTokenSource();
            _cancellationToken = _tokenSource.Token;
        }

        private void FrameProducer()
        {
            var producerActivity = true;
            var capture = new VideoCapture("rtsp://admin:admin@192.168.1.10/idc=1&ids=1");
            
            try
            {
                while (producerActivity)
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
            catch (OperationCanceledException cancelException)
            {
                capture.Dispose();
            }
        }

        public void Connect()
        {
            throw new IncorrectCameraStateException("Object has already connected with the camera");
        }

        public void Connect(string login, string password)
        {
            throw new IncorrectCameraStateException("Camera has already been connected.");
        }

        public void Disconnect()
        {
            _camera.SetClients(null, null);
            _camera.CameraStateObject = new CameraNotConnectedState(_camera);
        }

        public BlockingCollection<Bitmap> StartStreaming()
        {
            var capture = new VideoCapture("rtsp://admin:admin@192.168.1.10/idc=1&ids=1");

            capture.QueryFrame();

            throw new NotImplementedException();
        }

        public void StopStreaming()
        {
            throw new IncorrectCameraStateException("First you need to start streaming.");
        }

        public List<Profile> GetProfiles()
        {
            var profiles = _camera.MediaClient.GetProfilesAsync().Result.Profiles;

            return profiles.ToList();
        }
    }
}

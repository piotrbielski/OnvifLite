using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using CameraMediaService;
using OnvifLite.Attributes;
using System.Threading;
using System.Linq;
using OnvifLite.Exceptions;

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.Streaming)]
    internal class CameraStreamingState : ICameraState
    {
        private readonly Camera _camera;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public CameraStreamingState(Camera camera, CancellationTokenSource cancellationTokenSource)
        {
            _camera = camera;
            _cancellationTokenSource = cancellationTokenSource;
        }
        
        public void Connect()
        {
            throw new IncorrectCameraStateException("Object has already connected with the camera");
        }

        public void Disconnect()
        {
            _cancellationTokenSource.Cancel();
            _camera.StateObject = new CameraNotConnectedState(_camera);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile)
        {
            throw new IncorrectCameraStateException("Object is streaming frames now");
        }

        public void StopStreaming()
        {
            _cancellationTokenSource.Cancel();
            _camera.StateObject = new CameraConnectedState(_camera);
        }
    }
}

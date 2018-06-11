using System;
using System.Collections.Generic;
using System.Text;
using OnvifLite.Camera;
using OnvifLite.Exceptions;

namespace OnvifLite.CameraState
{
    internal class CameraConnectedState : ICameraState
    {
        private readonly ICamera _camera;

        public CameraConnectedState(ICamera camera)
        {
            _camera = camera;
        }

        public void Connect()
        {
            throw new IncorrectCameraStateException("Object has already connected with the camera");
        }

        public void StartStreaming()
        {
            throw new NotImplementedException();
        }

        public void StopStreaming()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using OnvifLite.Camera;

namespace OnvifLite.CameraState
{
    internal class CameraStreamingState : ICameraState
    {
        private readonly ICamera _camera;

        public CameraStreamingState(ICamera camera)
        {
            _camera = camera;
        }

        public void Connect()
        {
            throw new NotImplementedException();
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

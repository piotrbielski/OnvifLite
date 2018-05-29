using System;
using System.Collections.Generic;
using System.Text;
using OnvifLite.Exceptions;

namespace OnvifLite.CameraState
{
    internal class CameraConnectedState : ICameraState
    {
        public void Connect()
        {
            throw new IncorrectCameraStateException("Object has already connected with the camera");
        }

        public void Disconnect()
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

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using CameraMediaService;
using OnvifLite.Attributes;
using OnvifLite.Camera;

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.Streaming)]
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

        public void Connect(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public List<Profile> GetProfiles()
        {
            throw new NotImplementedException();
        }

        public BlockingCollection<Bitmap> StartStreaming()
        {
            throw new NotImplementedException();
        }

        public void StopStreaming()
        {
            throw new NotImplementedException();
        }
    }
}

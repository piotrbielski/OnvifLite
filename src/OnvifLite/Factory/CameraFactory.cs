using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using OnvifLite.Camera;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace OnvifLite.Factory
{
    public class CameraFactory : ICameraFactory
    {
        public ICamera CreateCamera(IPAddress ipAddress)
        {
            var camera = new Camera.Camera(ipAddress);
            return camera;
        }

        public ICamera CreateCamera(string login, string password, IPAddress ipAddress)
        {
            var camera = new Camera.Camera(ipAddress);
            camera.Connect(login, password);

            return camera;
        }
    }
}

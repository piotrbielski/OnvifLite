using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace OnvifLite
{
    public class CameraFactory : ICameraFactory
    {
        public ICamera CreateCamera(IPAddress ipAddress)
        {
            var camera = new Camera(ipAddress);
            return camera;
        }

        public ICamera CreateCamera(string login, string password, IPAddress ipAddress)
        {
            var camera = new Camera(ipAddress);
            camera.Connect(login, password);

            return camera;
        }
    }
}

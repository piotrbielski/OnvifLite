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
        public ICamera CreateCamera(string login, string password, IPAddress address)
        {
        }
    }
}

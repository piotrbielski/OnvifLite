using System;
using System.Collections.Generic;
using System.Text;
using OnvifLite.Camera;
using System.Net;

namespace OnvifLite.Factory
{
    public interface ICameraFactory
    {
        ICamera CreateCamera(string login, string password, IPAddress ipAddress);
    }
}

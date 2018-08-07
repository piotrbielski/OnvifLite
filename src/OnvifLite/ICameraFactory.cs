using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace OnvifLite
{
    public interface ICameraFactory
    {
        ICamera CreateCamera(IPAddress ipAddress);
        ICamera CreateCamera(string login, string password, IPAddress ipAddress);
    }
}

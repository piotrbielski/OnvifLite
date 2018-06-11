using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace OnvifLite.Discover
{
    public interface ICameraDiscover
    {
        IPAddress Discover();
    }
}

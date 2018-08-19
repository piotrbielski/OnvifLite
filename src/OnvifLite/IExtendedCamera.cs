using OnvifLite.CameraState;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite
{
    internal interface IExtendedCamera : ICamera
    {
        ICameraState StateObject { get; set; }
    }
}

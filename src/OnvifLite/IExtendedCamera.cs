using OnvifLite.CameraState;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("OnvifLiteTest")]

namespace OnvifLite
{
    internal interface IExtendedCamera : ICamera
    {
        ICameraState StateObject { get; set; }
    }
}

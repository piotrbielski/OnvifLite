using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite.CameraState
{
    public interface ICameraState
    {
        void Connect();
        void StartStreaming();
        void StopStreaming();
        void Disconnect();
    }
}

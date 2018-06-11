using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite.CameraState
{
    public interface ICameraState
    {
        void Connect(string login, string password);
        void Disconnect();
        void StartStreaming();
        void StopStreaming();
    }
}

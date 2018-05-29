using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using CameraMediaService;
using OnvifLite.CameraState;

namespace OnvifLite.Camera
{
    public interface ICamera
    {
        System.Net.IPAddress IPAddress { get; }
        Uri WebServiceAddress { get; }        
        List<Profile> Profiles { get; }
        CameraStateEnum State { get; }

        void Connect();
        void StartStreaming();
        void StopStreaming();
        void Disconnect();
    }
}

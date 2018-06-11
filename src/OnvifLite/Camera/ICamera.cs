using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using CameraMediaService;
using CameraManagementService;
using OnvifLite.CameraState;

namespace OnvifLite.Camera
{
    public interface ICamera
    {
        System.Net.IPAddress IPAddress { get; set; }
        Uri ServiceAddress { get; }     
        CameraStateEnum State { get; }
        List<Profile> Profiles { get; }

        void Connect(string login, string password);
        void Disconnect();
        void StartStreaming();
        void StopStreaming();
    }
}

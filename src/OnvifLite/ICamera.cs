using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using CameraMediaService;
using CameraManagementService;
using OnvifLite.CameraState;
using System.Collections.Concurrent;
using System.Drawing;

namespace OnvifLite
{
    public interface ICamera
    {
        System.Net.IPAddress IPAddress { get; set; }
        Uri ServiceAddress { get; }
        CameraStateEnum State { get; }
        List<Profile> Profiles { get; }

        void Connect(string login, string password);
        void Disconnect();
        BlockingCollection<Bitmap> StartStreaming();
        void StopStreaming();
    }
}

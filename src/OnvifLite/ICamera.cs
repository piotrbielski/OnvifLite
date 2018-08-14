using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using OnvifLite.CameraState;
using System.Collections.Concurrent;
using System.Drawing;
using OnvifLite.CameraMediaService;

namespace OnvifLite
{
    public interface ICamera
    {
        System.Net.IPAddress IPAddress { get; set; }
        Uri ServiceAddress { get; }
        CameraStateEnum State { get; }
        List<Profile> Profiles { get; }

        CameraUser ConnectionUser { get; }

        void Connect(string login, string password);
        void Disconnect();
        BlockingCollection<Bitmap> StartStreaming(Profile profile, int maxCollectionSize);
        void StopStreaming();
    }
}

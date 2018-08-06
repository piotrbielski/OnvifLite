using CameraMediaService;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Drawing;

namespace OnvifLite.CameraState
{
    public interface ICameraState
    {
        void Connect(string login, string password);
        void Disconnect();
        BlockingCollection<Bitmap> StartStreaming();
        void StopStreaming();

        List<Profile> GetProfiles();
    }
}
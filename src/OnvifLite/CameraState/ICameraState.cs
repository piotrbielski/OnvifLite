using CameraMediaService;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Drawing;

namespace OnvifLite.CameraState
{
    internal interface ICameraState
    {
        void Connect();
        void Disconnect();
        BlockingCollection<Bitmap> StartStreaming(Profile profile);
        void StopStreaming();
    }
}
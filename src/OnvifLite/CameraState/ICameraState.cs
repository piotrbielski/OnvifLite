using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Drawing;
using OnvifLite.CameraMediaService;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OnvifLiteTest")]

namespace OnvifLite.CameraState
{
    internal interface ICameraState
    {
        void Connect();
        void Disconnect();
        BlockingCollection<Bitmap> StartStreaming(Profile profile, int maxCollectionSize);
        void StopStreaming();
    }
}
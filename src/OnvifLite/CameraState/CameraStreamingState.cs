using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OnvifLite.Attributes;
using System.Threading;
using System.Linq;
using OnvifLite.Exceptions;
using OnvifLite.CameraMediaService;
using OnvifLite.Proxy;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OnvifLiteTest, PublicKey=0024000004800000940000000602000000240000525341310004000001000100594fb5574b1580" +
                                                       "e39fa8ca4a19886b9b3d016f3663a1142cdd2151f635004eefed3cabe1776bb051fc2d116975b4" +
                                                       "3e91175e14b51dfcede5a544ed668d20b21b08367ce2f32180a3483021cf33831f6493944aa151" +
                                                       "78337562c4a5b76843d16122847c1267394575d66dca4ed290924e875513b51c6dcc213e981b3d" +
                                                       "2290baed")]

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.Streaming)]
    internal class CameraStreamingState : ICameraState
    {
        private readonly IExtendedCamera _camera;
        private readonly IProxyFactory _proxyFactory;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public CameraStreamingState(IExtendedCamera camera, IProxyFactory proxyFactory, CancellationTokenSource cancellationTokenSource)
        {
            _camera = camera;
            _proxyFactory = proxyFactory;
            _cancellationTokenSource = cancellationTokenSource;
        }
        
        public void Connect()
        {
            throw new IncorrectCameraStateException("Object has already connected with the camera");
        }

        public void Disconnect()
        {
            _cancellationTokenSource.Cancel();
            _camera.StateObject = new CameraNotConnectedState(_camera, _proxyFactory);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile, int maxCollectionSize)
        {
            throw new IncorrectCameraStateException("Object is streaming frames now");
        }

        public void StopStreaming()
        {
            _cancellationTokenSource.Cancel();
            _camera.StateObject = new CameraConnectedState(_camera, _proxyFactory);
        }
    }
}

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

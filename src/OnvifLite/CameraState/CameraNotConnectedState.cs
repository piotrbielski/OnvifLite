﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Net;
using System.Linq;
using OnvifLite.Exceptions;
using OnvifLite.Attributes;
using System.Collections.Concurrent;
using System.Drawing;
using OnvifLite.Proxy;
using OnvifLite.CameraManagementService;
using OnvifLite.CameraMediaService;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OnvifLiteTest")]

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.NotConnected)]
    internal class CameraNotConnectedState : ICameraState
    {
        private readonly IExtendedCamera _camera;
        private readonly IProxyFactory _proxyFactory;

        public CameraNotConnectedState(IExtendedCamera camera, IProxyFactory proxyFactory)
        {
            _camera = camera;
            _proxyFactory = proxyFactory;
        }

        public void Connect()
        {
            try
            {
                using (var deviceClient = _proxyFactory.Create<Device, DeviceClient>(_camera.ServiceAddress))
                {
                    var timeTest = deviceClient.GetSystemDateAndTimeAsync().Result;
                }
            }
            catch (AggregateException aggregateException)
            {
                var endpointNotFoundException = aggregateException.InnerExceptions.FirstOrDefault(x => x.GetType() == typeof(EndpointNotFoundException));

                if (endpointNotFoundException != null)
                    throw new CameraConnectionException("Can not connect to a camera with a defined address. Check the endpoint address.", endpointNotFoundException);
                else
                    throw new CameraConnectionException("An unknown error occurred while connecting to the camera. Check the endpoint address and the user credential.", aggregateException);
            }
            catch (EndpointNotFoundException endpointNotFoundException)
            {
                throw new CameraConnectionException("Can not connect to a camera with a defined address. Check the endpoint address.", endpointNotFoundException);
            }
            catch (Exception exception)
            {
                throw new CameraConnectionException("An unknown error occurred while connecting to the camera. Check the endpoint address and the user credential.", exception);
            }

            _camera.StateObject = new CameraConnectedState(_camera, _proxyFactory);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile, int maxCollectionSize)
        {
            throw new IncorrectCameraStateException("Cannot start streaming, camera is not connected.");
        }

        public void StopStreaming()
        {
            throw new IncorrectCameraStateException("Cannot stop streaming, camera is not connected.");
        }

        public void Disconnect()
        {
            throw new IncorrectCameraStateException("Camera has already been disconnected.");
        }
    }
}

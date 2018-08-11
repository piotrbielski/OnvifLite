using System;
using System.Collections.Generic;
using System.Text;
using CameraMediaService;
using CameraManagementService;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Net;
using System.Linq;
using OnvifLite.Exceptions;
using OnvifLite.Attributes;
using System.Collections.Concurrent;
using System.Drawing;
using OnvifLite.Proxy;

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.NotConnected)]
    internal class CameraNotConnectedState : ICameraState
    {
        private readonly Camera _camera;

        public CameraNotConnectedState(Camera camera)
        {
            _camera = camera;
        }

        public void Connect()
        {
            try
            {
                using (var deviceClient = ProxyFactory<Device, DeviceClient>.Create(_camera.ServiceAddress))
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

            _camera.StateObject = new CameraConnectedState(_camera);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile)
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

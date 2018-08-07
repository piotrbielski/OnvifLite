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

        private MediaClient CreateMediaClient()
        {
            var messageBindingElement = new TextMessageEncodingBindingElement()
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.WSAddressing10)
            };

            var transportBindingElement = new HttpTransportBindingElement()
            {
                AuthenticationScheme = AuthenticationSchemes.Digest
            };

            var customBinding = new CustomBinding(messageBindingElement, transportBindingElement);

            var mediaClient = new MediaClient(customBinding, new EndpointAddress(_camera.ServiceAddress));

            return mediaClient;
        }

        private DeviceClient CreateDeviceClient()
        {
            var messageBindingElement = new TextMessageEncodingBindingElement()
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.WSAddressing10)
            };

            var transportBindingElement = new HttpTransportBindingElement()
            {
                AuthenticationScheme = AuthenticationSchemes.Digest
            };

            var customBinding = new CustomBinding(messageBindingElement, transportBindingElement);

            var deviceClient = new DeviceClient(customBinding, new EndpointAddress(_camera.ServiceAddress));

            return deviceClient;
        }

        public void Connect(string login, string password)
        {
            var credential = new NetworkCredential(login, password);

            var mediaClient = CreateMediaClient();
            //not supported in net standard
            //mediaClient.ClientCredentials.HttpDigest.ClientCredential = credential;

            var deviceClient = CreateDeviceClient();
            //not supported in net standard
            //deviceClient.ClientCredentials.HttpDigest.ClientCredential = credential;

            try
            {
                var timeTest = deviceClient.GetSystemDateAndTimeAsync().Result;
                var profilesTest = mediaClient.GetProfilesAsync().Result;
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

            _camera.SetClients(deviceClient, mediaClient);
            _camera.CameraStateObject = new CameraConnectedState(_camera);
        }

        public BlockingCollection<Bitmap> StartStreaming()
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

        public List<Profile> GetProfiles()
        {
            throw new IncorrectCameraStateException("The camera must be connected");
        }
    }
}

using OnvifLite.Camera;
using System;
using System.Collections.Generic;
using System.Text;
using CameraMediaService;
using CameraManagementService;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Net;
using OnvifLite.Exceptions;
using OnvifLite.Attributes;

namespace OnvifLite.CameraState
{
    [CameraState(CameraStateEnum.NotConnected)]
    internal class CameraNotConnectedState : ICameraState
    {
        private readonly Camera.Camera _camera;

        public CameraNotConnectedState(Camera.Camera camera)
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

            var mediaClient = new MediaClient(customBinding, new EndpointAddress(_camera.IPAddress.ToString()));

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

            var deviceClient = new DeviceClient(customBinding, new EndpointAddress(_camera.IPAddress.ToString()));

            return deviceClient;
        }

        public void Connect(string login, string password)
        {
            var credential = new NetworkCredential(login, password);

            var mediaClient = CreateMediaClient();
            mediaClient.ClientCredentials.HttpDigest.ClientCredential = credential;

            var deviceClient = CreateDeviceClient();
            deviceClient.ClientCredentials.HttpDigest.ClientCredential = credential;

            try
            {
                var timeTest = deviceClient.GetSystemDateAndTimeAsync().Result;
                var profilesTest = mediaClient.GetProfilesAsync().Result;
            }
            catch(EndpointNotFoundException endpointNotFoundException)
            {
                throw new CameraConnectionException("Can not connect to a camera with a defined address. Check the endpoint address.", endpointNotFoundException);
            }
            catch(Exception exception)
            {
                throw new CameraConnectionException("An unknown error occurred while connecting to the camera. Check the endpoint address and the user credential.", exception);
            }

            _camera.DeviceClient = deviceClient;
            _camera.MediaClient = mediaClient;
            _camera.CameraStateObject = new CameraConnectedState(_camera);
        }

        public void StartStreaming()
        {
            throw new CameraConnectionException("Cannot start streaming, camera is not connected.");
        }

        public void StopStreaming()
        {
            throw new CameraConnectionException("Cannot stop streaming, camera is not connected.");
        }

        public void Disconnect()
        {
            throw new CameraConnectionException("Camera has already been disconnected.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using OnvifLite.CameraState;
using OnvifLite.Attributes;
using System.Reflection;
using System.Linq;
using System.Collections.Concurrent;
using System.Drawing;
using OnvifLite.Proxy;
using OnvifLite.Exceptions;
using OnvifLite.CameraMediaService;

namespace OnvifLite
{
    internal class Camera : ICamera
    {
        private System.Net.IPAddress _ipAddress;

        public ICameraState StateObject { get; set; }

        public System.Net.IPAddress IPAddress
        {
            get
            {
                return _ipAddress;
            }

            set
            {
                if (State == CameraStateEnum.NotConnected)
                    _ipAddress = value;
                else
                    throw new IncorrectCameraStateException("The camera must be in an unconnected state.");
            }
        }

        public Uri ServiceAddress => _ipAddress != null 
            ? new Uri($"http://{IPAddress.ToString()}/onvif/device_service") 
            : throw new InvalidOperationException("The camera does not have a IP address.");
        
        public List<Profile> Profiles
        {
            get
            {
                if (State != CameraStateEnum.NotConnected)
                {
                    using (var mediaClient = ProxyFactory<Media, MediaClient>.Create(ServiceAddress))
                    {
                        return mediaClient.GetProfilesAsync().Result.Profiles.ToList();
                    }
                }
                else
                    throw new IncorrectCameraStateException("The camera must be in connected state.");
            }
        }

        public CameraUser ConnectionUser { get; private set; }

        public CameraStateEnum State
        {
            get
            {
                var attributes = StateObject.GetType().GetTypeInfo().GetCustomAttributes();
                var cameraStateAttribute = attributes.First(x => x.GetType().FullName.Contains(nameof(CameraStateAttribute)));

                if (cameraStateAttribute is CameraStateAttribute state)
                    return state.State;
                else
                    throw new MissingExpectedAttributeException("CameraStateAttribute not found.");
            }
        }

        public Camera(System.Net.IPAddress ipAddress)
        {            
            StateObject = new CameraNotConnectedState(this);
            IPAddress = ipAddress;
        }

        public Camera()
        {
            StateObject = new CameraNotConnectedState(this);
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile, int maxCollectionSize)
        {
            return StateObject.StartStreaming(profile, maxCollectionSize);
        }

        public void StopStreaming()
        {
            StateObject.StopStreaming();
        }

        public void Connect(string login, string password)
        {
            ConnectionUser = new CameraUser(login, password);
            StateObject.Connect();
        }

        public void Disconnect()
        {
            StateObject.Disconnect();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net;
using CameraMediaService;
using OnvifLite.CameraState;
using OnvifLite.Attributes;
using CameraManagementService;
using System.Reflection;
using System.Linq;
using System.Collections.Concurrent;
using System.Drawing;

namespace OnvifLite
{
    internal class Camera : ICamera
    {
        public ICameraState StateObject { get; set; }

        public MediaClient MediaClient { get; private set; }
        public DeviceClient DeviceClient { get; private set; }

        public System.Net.IPAddress IPAddress { get; set; }
        public Uri ServiceAddress => new Uri($"http://{IPAddress.ToString()}/onvif/device_service");

        public List<Profile> Profiles => State != CameraStateEnum.NotConnected ? MediaClient.GetProfilesAsync().Result.Profiles.ToList() : new List<Profile>();

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
                    throw new Exception(); //todo wyjątek
            }
        }

        public Camera(System.Net.IPAddress ipAddress)
        {
            IPAddress = ipAddress;
            StateObject = new CameraNotConnectedState(this);
        }

        public Camera()
        {
            StateObject = new CameraNotConnectedState(this);
        }

        public void SetClients(DeviceClient deviceClient, MediaClient mediaClient)
        {
            DeviceClient = deviceClient;
            MediaClient = mediaClient;
        }

        public BlockingCollection<Bitmap> StartStreaming(Profile profile)
        {
            return StateObject.StartStreaming(profile);
        }

        public void StopStreaming()
        {
            StateObject.StopStreaming();
        }

        public void Connect(string login, string password)
        {
            ConnectionUser = new CameraUser(login, password);
            StateObject.Connect(login, password);
        }

        public void Disconnect()
        {
            StateObject.Disconnect();
        }
    }
}
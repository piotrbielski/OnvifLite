using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.ServiceModel;
using CameraMediaService;
using OnvifLite.CameraState;
using OnvifLite.Attributes;
using CameraManagementService;
using System.Reflection;
using System.Linq;
using System.Collections.Concurrent;
using System.Drawing;

namespace OnvifLite.Camera
{
    internal class Camera : ICamera
    {
        public ICameraState CameraStateObject { get; set; }

        public MediaClient MediaClient { get; private set; }
        public DeviceClient DeviceClient { get; private set; }

        public System.Net.IPAddress IPAddress { get; set; }
        public Uri ServiceAddress => new Uri($"http://{IPAddress.ToString()}/onvif/device_service");

        public List<Profile> Profiles => State != CameraStateEnum.NotConnected ? MediaClient.GetProfilesAsync().Result.Profiles.ToList() : new List<Profile>();

        public CameraStateEnum State
        {
            get
            {
                var attributes = CameraStateObject.GetType().GetTypeInfo().GetCustomAttributes();
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
            CameraStateObject = new CameraNotConnectedState(this);
        }

        public Camera()
        {
            CameraStateObject = new CameraNotConnectedState(this);
        }

        public void SetClients(DeviceClient deviceClient, MediaClient mediaClient)
        {
            DeviceClient = deviceClient;
            MediaClient = mediaClient;
        }

        public BlockingCollection<Bitmap> StartStreaming()
        {
            return CameraStateObject.StartStreaming();
        }

        public void StopStreaming()
        {
            CameraStateObject.StopStreaming();
        }

        public void Connect(string login, string password)
        {
            CameraStateObject.Connect(login, password);
        }

        public void Disconnect()
        {
            CameraStateObject.Disconnect();
        }
    }
}
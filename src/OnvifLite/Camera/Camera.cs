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
using CameraMediaService;
using CameraManagementService;
using System.Reflection;
using System.Linq;

namespace OnvifLite.Camera
{
    internal class Camera : ICamera
    {
        public ICameraState CameraStateObject { get; set; }

        public MediaClient MediaClient { get; set; }
        public DeviceClient DeviceClient { get; set; }

        public System.Net.IPAddress IPAddress { get; set; }

        public Uri ServiceAddress => new Uri($"http://{IPAddress.ToString()}/onvif/device_service");

        public List<Profile> Profiles => State != CameraStateEnum.NotConnected ? MediaClient.GetProfilesAsync().Result.Profiles.ToList() : new List<Profile>();

        public CameraStateEnum State
        {
            get
            {
                var attributes = CameraStateObject.GetType().GetTypeInfo().GetCustomAttributes();
                var cameraStateAttribute = attributes.First(x => x.GetType().FullName.Contains(nameof(CameraStateAttribute)));

                var state = cameraStateAttribute as CameraStateAttribute;

                if (state != null)
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

        public void StartStreaming()
        {
            throw new NotImplementedException();
        }

        public void StopStreaming()
        {
            throw new NotImplementedException();
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

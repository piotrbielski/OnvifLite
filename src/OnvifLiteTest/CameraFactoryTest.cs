using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnvifLite;
using OnvifLite.CameraState;
using OnvifLite.Exceptions;
using System.Net;

namespace OnvifLiteTest
{
    [TestClass]
    public class CameraFactoryTest
    {
        [TestMethod]
        public void CreateNotConnectedCameraTest()
        {
            var ipAddress = IPAddress.Parse("192.168.0.1");
            var cameraFactory = new CameraFactory();
            var camera = cameraFactory.CreateCamera(ipAddress);

            Assert.AreEqual(ipAddress, camera.IPAddress);
            Assert.AreEqual(camera.State, CameraStateEnum.NotConnected);
        }

        [TestMethod]
        public void CreateNotConnectedCameraExceptionTest()
        {
            var ipAddress = IPAddress.Parse("192.168.0.1");
            var cameraFactory = new CameraFactory();

            try
            {
                var camera = cameraFactory.CreateCamera("admin", "admin", ipAddress);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(CameraConnectionException), e.GetType());
            }            
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OnvifLite;
using OnvifLite.CameraState;
using OnvifLite.Proxy;
using System.Runtime.CompilerServices;
using OnvifLite.CameraManagementService;
using System.ServiceModel;
using OnvifLite.Exceptions;

namespace OnvifLiteTest
{
    [TestClass]
    public class NotConnectedStateTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            var serviceTest = new Mock<Device>();
            var cameraTest = new Mock<IExtendedCamera>();
            var proxyFactoryTest = new Mock<IProxyFactory>();

            serviceTest.Setup(x => x.GetSystemDateAndTimeAsync()).ReturnsAsync(new SystemDateTime());
            proxyFactoryTest.Setup(x => x.Create<Device, DeviceClient>(It.IsAny<Uri>())).Returns(() => serviceTest.Object);

            var notConnectedState = new CameraNotConnectedState(cameraTest.Object, proxyFactoryTest.Object);
            notConnectedState.Connect();

            cameraTest.VerifySet(x => x.StateObject = It.Is<ICameraState>(y => y.GetType() == typeof(CameraConnectedState)));
        }

        [TestMethod]
        public void ThrowExceptionWhileConnectingTest()
        {
            var serviceTest = new Mock<Device>();
            var cameraTest = new Mock<IExtendedCamera>();
            var proxyFactoryTest = new Mock<IProxyFactory>();

            serviceTest.Setup(x => x.GetSystemDateAndTimeAsync()).ThrowsAsync(new EndpointNotFoundException());
            proxyFactoryTest.Setup(x => x.Create<Device, DeviceClient>(It.IsAny<Uri>())).Returns(() => serviceTest.Object);

            try
            {
                var notConnectedState = new CameraNotConnectedState(cameraTest.Object, proxyFactoryTest.Object);
                notConnectedState.Connect();
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(CameraConnectionException), e.GetType());
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void StartStreamingTest()
        {
            try
            {
                var notConnectedState = new CameraNotConnectedState(It.IsAny<IExtendedCamera>(), It.IsAny<IProxyFactory>());
                notConnectedState.StartStreaming(null, 10);
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(IncorrectCameraStateException), e.GetType());
                return;
            }
        }

        [TestMethod]
        public void StopStreamingTest()
        {
            try
            {
                var notConnectedState = new CameraNotConnectedState(It.IsAny<IExtendedCamera>(), It.IsAny<IProxyFactory>());
                notConnectedState.StopStreaming();
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(IncorrectCameraStateException), e.GetType());
                return;
            }
        }

        [TestMethod]
        public void DisconnectTest()
        {
            try
            {
                var notConnectedState = new CameraNotConnectedState(It.IsAny<IExtendedCamera>(), It.IsAny<IProxyFactory>());
                notConnectedState.Disconnect();
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(IncorrectCameraStateException), e.GetType());
                return;
            }
        }
    }
}

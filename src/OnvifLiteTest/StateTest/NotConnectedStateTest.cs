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

namespace OnvifLiteTest.StateTest
{
    [TestClass]
    public class NotConnectedStateTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            var serviceMock = new Mock<Device>();
            var cameraMock = new Mock<IExtendedCamera>();
            var proxyFactoryMock = new Mock<IProxyFactory>();

            serviceMock.Setup(x => x.GetSystemDateAndTimeAsync()).ReturnsAsync(new SystemDateTime());
            proxyFactoryMock.Setup(x => x.Create<Device, DeviceClient>(It.IsAny<Uri>())).Returns(() => serviceMock.Object);

            var notConnectedState = new CameraNotConnectedState(cameraMock.Object, proxyFactoryMock.Object);
            notConnectedState.Connect();

            cameraMock.VerifySet(x => x.StateObject = It.Is<ICameraState>(y => y.GetType() == typeof(CameraConnectedState)));
        }

        [TestMethod]
        public void ThrowExceptionWhileConnectingTest()
        {
            var serviceMock = new Mock<Device>();
            var cameraMock = new Mock<IExtendedCamera>();
            var proxyFactoryMock = new Mock<IProxyFactory>();

            serviceMock.Setup(x => x.GetSystemDateAndTimeAsync()).ThrowsAsync(new EndpointNotFoundException());
            proxyFactoryMock.Setup(x => x.Create<Device, DeviceClient>(It.IsAny<Uri>())).Returns(() => serviceMock.Object);

            try
            {
                var notConnectedState = new CameraNotConnectedState(cameraMock.Object, proxyFactoryMock.Object);
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

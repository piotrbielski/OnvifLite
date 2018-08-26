using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnvifLite.CameraState;
using OnvifLite.Exceptions;
using OnvifLite.Proxy;
using OnvifLite;
using Moq;
using OnvifLite.CameraMediaService;

namespace OnvifLiteTest.StateTest
{
    [TestClass]
    public class ConnectedStateTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            try
            {
                var connectedState = new CameraConnectedState(It.IsAny<IExtendedCamera>(), It.IsAny<IProxyFactory>());
                connectedState.Connect();
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(IncorrectCameraStateException), e.GetType());
            }
        }

        [TestMethod]
        public void StartStreamingTest()
        {
            var cameraMock = new Mock<IExtendedCamera>();
            var proxyFactoryMock = new Mock<IProxyFactory>();
            var mediaClientMock = new Mock<Media>();

            mediaClientMock.Setup(x => x.GetStreamUriAsync(It.IsAny<StreamSetup>(), It.IsAny<string>()))
                .ReturnsAsync(new MediaUri() { Uri = "rtsp://test.com" });
            proxyFactoryMock.Setup(x => x.Create<Media, MediaClient>(It.IsAny<Uri>()))
                .Returns(() => mediaClientMock.Object);
            cameraMock.Setup(x => x.ConnectionUser).Returns(new CameraUser("test", "test"));

            var connectedState = new CameraConnectedState(cameraMock.Object, proxyFactoryMock.Object);
            connectedState.StartStreaming(new Profile() { token = "192.168.0.1" }, 10);

            cameraMock.VerifySet(x => x.StateObject = It.Is<ICameraState>(y => y.GetType() == typeof(CameraStreamingState)));
        }
    }
}

using OnvifLite.CameraState;
using OnvifLite.Exceptions;
using OnvifLite.Proxy;
using OnvifLite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading;
using System;
using OnvifLite.CameraMediaService;

namespace OnvifLiteTest.StateTest
{
    [TestClass]
    public class StreamingStateTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            var streamingTest = new CameraStreamingState(It.IsAny<IExtendedCamera>(), It.IsAny<IProxyFactory>(), It.IsAny<CancellationTokenSource>());
            
            try
            {
                streamingTest.Connect();
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(IncorrectCameraStateException), e.GetType());
            }
        }

        [TestMethod]
        public void StartStreamingTest()
        {
            var streamingTest = new CameraStreamingState(It.IsAny<IExtendedCamera>(), It.IsAny<IProxyFactory>(), It.IsAny<CancellationTokenSource>());

            try
            {
                streamingTest.StartStreaming(It.IsAny<Profile>(), 10);
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(IncorrectCameraStateException), e.GetType());
            }
        }

        [TestMethod]
        public void StopStreamingTest()
        {
            var tokenSource = new CancellationTokenSource();
            var cameraMock = new Mock<IExtendedCamera>();

            var streamingTest = new CameraStreamingState(cameraMock.Object, It.IsAny<IProxyFactory>(), tokenSource);
            streamingTest.StopStreaming();

            cameraMock.VerifySet(x => x.StateObject = It.Is<ICameraState>(y => y.GetType() == typeof(CameraConnectedState)));
            Assert.AreEqual(true, tokenSource.IsCancellationRequested);
        }

        [TestMethod]
        public void DisconnectTest()
        {
            var tokenSource = new CancellationTokenSource();
            var cameraMock = new Mock<IExtendedCamera>();

            var streamingTest = new CameraStreamingState(cameraMock.Object, It.IsAny<IProxyFactory>(), tokenSource);
            streamingTest.Disconnect();

            cameraMock.VerifySet(x => x.StateObject = It.Is<ICameraState>(y => y.GetType() == typeof(CameraNotConnectedState)));
            Assert.AreEqual(true, tokenSource.IsCancellationRequested);
        }
    }
}

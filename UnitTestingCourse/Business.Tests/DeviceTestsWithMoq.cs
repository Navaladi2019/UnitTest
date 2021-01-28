using System;
using System.Threading.Tasks;
using Moq;
using NSubstitute;
using NUnit.Framework;

namespace Business.Tests
{
    [TestFixture]
    public class DeviceTestsWithMoq
    {
        [Test]
        public void Connect_FailedThrice_ThreeTries()
        {
            var provider = new Mock<IProtocol>();
            provider.Setup(x => x.Connect(It.IsAny<string>())).Returns(false);
                //.re(false);

            //            provider.Connect(Arg.Is("COM1")).Returns(true);
            //            provider.Connect(Arg.Is<string>(x=>x.StartsWith("COM"))).Returns(true);

            var sut = new Device(provider.Object);
            sut.Connect(string.Empty);

            //provider.Received(3).Connect(Arg.Any<string>());
        }

        [Test]
        public void Find_FoundOnCOM1_ReturnsCOM1()
        {
            var provider = new Mock<IProtocol>();
            var sut = new Device(provider.Object);
            Task<string> task = sut.Find();

            const string portName = "COM1";

            //provider.SearchingFinished += Raise.Event<EventHandler<DeviceSearchingEventArgs>>
                //(provider, new DeviceSearchingEventArgs(portName));

            Assert.That(task.Result, Is.EqualTo(portName));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Operations.Implementations;

namespace Operations.Tests
{
    [TestClass]
    public class MessagingTests
    {
        [TestMethod]
        public void GetMessage_Test()
        {
            // arrange
            var mockMessaging = new Mock<Messaging>();

            // act
            mockMessaging.Setup(x => x.GetMessage()).Returns("Hello World");

            var message = mockMessaging.Object.GetMessage();
            
            // assert
            Assert.IsTrue(message == "Hello World");
        }
    }
}

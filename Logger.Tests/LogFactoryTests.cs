using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {

        [TestMethod]
        public void Set_ClassName_InBaseLogger()
        {
            // Arrange
            LogFactory.CreateLogger("Test Name");
            // Act
            //BaseLoggerMixins.Error(null, "");

            // Assert
            Assert.AreEqual("Test Name", BaseLogger.Name);
        }
    }
}

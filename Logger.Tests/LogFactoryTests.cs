using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests : BaseLogger
    {
        public override void Log(LogLevel logLevel, string message)
        {
            throw new System.NotImplementedException();
        }

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

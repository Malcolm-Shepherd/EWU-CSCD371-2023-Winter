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
            LogFactory factory = new LogFactory();

            // Act
            BaseLogger logger = factory.CreateLogger("Test Name");

            // Assert
            Assert.AreEqual("Test Name", BaseLogger.Name);
        }

        [TestMethod]
        public void Set_FilePath_InConfigureFileLogger()
        {
            // Arrange
            LogFactory factory = new LogFactory();

            // Act
            factory.ConfigureFileLogger("Logger.txt");
            BaseLogger logger = factory.CreateLogger("Test Name");

            // Assert
            Assert.AreEqual(BaseLogger.Path, "Logger.txt");
        }

        [TestMethod]
        public void Null_FilePath_ReturnsNull()
        {
            // Arrange
            LogFactory factory = new LogFactory();

            // Act
            BaseLogger logger = factory.CreateLogger("Test Name");

            // Assert
            Assert.IsNull(logger);
        }
    }
}

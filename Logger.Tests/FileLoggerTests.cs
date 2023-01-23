using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void FileLogger_Inherits_BaseLogger()
        {

            Assert.IsTrue(typeof(FileLogger).IsSubclassOf(typeof(BaseLogger)));
        }

        [TestMethod]
        public void Log_Appends_ToFile()
        {
            /*
             * This test is appending to a Log.txt in Logger.Tests/bin/Debug/net6.0
             * It is not appending to the Log.txt in the Logger folder
             */
            FileLogger appender = new FileLogger();
            string testMessage = "Append This Text";
            string[] oldText = File.ReadAllLines("Log.txt");


            appender.Log(new LogLevel(), testMessage);
            string[] newText = File.ReadAllLines("Log.txt");

            for(int i = 0; i < oldText.Length; i++) 
            {
                Assert.AreEqual(oldText[i], newText[i]);
            }
            Assert.AreEqual(newText[oldText.Length].Substring(0, testMessage.Length), testMessage);
        }
    }
}

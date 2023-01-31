using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeWriterTests
    {
        [TestMethod]
        public void JokeToConsole_WritesInput_ToConsole()
        {
            JokeWriter testWriter = new JokeWriter();
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            string input = "Really Funny";
            string expected = string.Format(input+"{0}", Environment.NewLine); 

            testWriter.JokeToConsole(input);
            string actual = output.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}

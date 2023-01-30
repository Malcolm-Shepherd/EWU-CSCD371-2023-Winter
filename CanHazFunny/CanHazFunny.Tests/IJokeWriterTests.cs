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
    public class IJokeWriterTests
    {
        [TestMethod]
        public void JokeToConsole_WritesInput_ToConsole()
        {
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            string input = "Really Funny";
            string expected = string.Format(input+"{0}", Environment.NewLine); 

            IJokeWriter.JokeToConsole(input);
            string? actual = output.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}

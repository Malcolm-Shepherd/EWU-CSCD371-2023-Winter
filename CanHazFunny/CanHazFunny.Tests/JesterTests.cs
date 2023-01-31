using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        //test Telljoke() without Chuck Norris
        //test Telljoke() with Chuck Norris
        //test other functions and stuff

        //does jester implement jokeservice
        //does jester implement jokewriter
        [TestMethod]
        public void Constructor_Interfaces_as_Dependencies()
        {
            JokeService testService = new JokeService();
            JokeWriter testWriter = new JokeWriter();
            Jester tester = new Jester(testService, testWriter);

            Assert.AreEqual<JokeService>(testService, tester.JokeIn);
            Assert.AreEqual<JokeWriter>(testWriter, tester.JokeOut);
        }

        [TestMethod]
        public void JokeService_NullChecked()
        {
            ArgumentNullException? nullCheck1 = null;

            try { Jester nullPerson1 = new Jester(null!, new JokeWriter()); }
            catch(ArgumentNullException ex) { nullCheck1 = ex; }
            Assert.IsNotNull(nullCheck1);

        }

        [TestMethod]
        public void MyTestMethod()
        {
            ArgumentNullException? nullCheck2 = null;

            try { Jester nullPerson2 = new Jester(new JokeService(), null!); }
            catch (ArgumentNullException ex) { nullCheck2 = ex; }
            Assert.IsNotNull(nullCheck2);
        }
    }
}

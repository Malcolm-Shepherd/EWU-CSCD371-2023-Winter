using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestMethod]
        public void JokeService_Implements_IJokeService_True()
        {
            Assert.IsTrue(typeof(Jester).GetInterfaces().Contains(typeof(IJokeService)));
        }
        //does jester implement jokewriter
        [TestMethod]
        public void JokeService_Implements_IJokeWriter_True()
        {
            Assert.IsTrue(typeof(Jester).GetInterfaces().Contains(typeof(IJokeWriter)));
        }
    }
}

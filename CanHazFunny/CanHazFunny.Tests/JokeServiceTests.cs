using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Reflection;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServiceTests
    {
        //test if jokeservice class implements IJokeservice
        [TestMethod]
        public void JokeService_Implements_IJokeService_True()
        {
            Assert.IsTrue(typeof(JokeService).GetInterfaces().Contains(typeof(IJokeService)));
        }
    }
}

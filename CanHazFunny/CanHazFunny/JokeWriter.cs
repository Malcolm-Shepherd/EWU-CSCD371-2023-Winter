using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class JokeWriter : IJokeWriter
    {
        public void JokeToConsole(string inputJoke)
        {
            Console.WriteLine(inputJoke);
        }
    }
}

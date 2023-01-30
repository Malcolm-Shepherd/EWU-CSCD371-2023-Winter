using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{

    public interface IJokeWriter 
    {
        static void JokeToConsole(string inputJoke)
        {
            Console.WriteLine(inputJoke);
        }
    }
}

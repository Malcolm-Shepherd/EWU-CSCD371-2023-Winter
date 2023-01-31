using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanHazFunny;


namespace CanHazFunny
{
    public class Jester
    {
        private JokeService? _JokeIn; 
        private JokeWriter? _JokeOut;

        public JokeService JokeIn { 
            get {
                return _JokeIn!;
            }
            set {
                _JokeIn = value ?? throw new ArgumentNullException(nameof(value));
            } 
        }
        public JokeWriter JokeOut
        {
            get
            {
                return _JokeOut!;
            }
            set
            {
                _JokeOut = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public Jester(JokeService jokeIn, JokeWriter jokeOut) 
        {
            JokeIn = jokeIn;
            JokeOut = jokeOut;
        }
        public void TellJoke()
        {
            string joke;
            do { joke = this.JokeIn.GetJoke(); }
            while (joke.Contains("Chuck Norris"));

            this.JokeOut.JokeToConsole(joke);
        }

    }
}





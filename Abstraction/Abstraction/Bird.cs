using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Bird
    {
        public string birdName(string bName)
        {
            return "The bird's name is " + bName;
        }
        public abstract void birdSound();
        public abstract string birdArea();

    }

    class Crow:Bird
    {
        public override void birdSound()
        {
            Console.WriteLine("kaak-kaak");
        }
        public override string birdArea()
        {
            return "City";
        }
    }
}

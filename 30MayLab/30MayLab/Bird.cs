using System;
using System.Collections.Generic;
using System.Text;

namespace _30MayLab
{
    class Bird : Animal
    {
        public Bird(string name):base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("I can Fly!");
        }
    }
}

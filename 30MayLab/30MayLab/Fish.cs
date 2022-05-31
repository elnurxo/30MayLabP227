using System;
using System.Collections.Generic;
using System.Text;

namespace _30MayLab
{
    class Fish:Animal
    {
        public Fish(string name):base(name)
        {
        }
        public void Swim()
        {
            Console.WriteLine("I can swim!");
        }

    }
}

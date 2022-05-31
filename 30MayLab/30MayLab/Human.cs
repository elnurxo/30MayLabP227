using System;
using System.Collections.Generic;
using System.Text;

namespace _30MayLab
{
    internal class Human
    {
        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = 10;
        }


        public string Name;
        public string Surname;
        public byte Age;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname}, {Age}");
        }
    }
}

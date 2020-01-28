using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool Radiation { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Famous { get; set; }

        public void PrintRep()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{Name} is {Color}, {Legs} legged and a {Eat}.");
            Console.WriteLine($"Can {Name} be a pet? {Pet}");
            Console.WriteLine($"Endangered? {End}");
            Console.WriteLine($"Got radiation? {Radiation}");
            Console.WriteLine($"{Famous}");
        }
    }
}

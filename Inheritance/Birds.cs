using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Birds : Animal
    {
        public bool GotWings { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Famous { get; set; }

        public void PrintBird()
        {
            Console.WriteLine($"The {Name} is {Color}, {Legs} legged and an {Eat}.");
            Console.WriteLine($"Can a {Name} be a pet? {Pet}");
            Console.WriteLine($"Endangered? {End}");
            Console.WriteLine($"Got wings? {GotWings}");
            Console.WriteLine($"{Famous}");
        }
    }
}

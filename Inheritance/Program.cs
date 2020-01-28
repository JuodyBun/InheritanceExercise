using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Birds toucan = new Birds
            {
                Legs = 2, 
                Eat = "omnivore",
                Pet = "Maybe", 
                End = true, 
                GotWings = true,
                Name = "toucan",
                Color = "rainbow colored",
                Famous = "Toucan Sam: Cartoon toucan mascot for Froot Loops breakfast cereal.",
            };

            toucan.PrintBird();

            Reptile godzilla = new Reptile
            {
                Legs = 2, 
                Eat = "carnivore", 
                Pet = "Definitely", 
                End = true,
                Radiation = true,
                Name = "Godzilla",
                Color = "grayish green colored",
                Famous = "Godzilla is depicted as an enormous, destructive, prehistoric sea monster awakened and empowered by nuclear radiation. With the nuclear bombings of Hiroshima and Nagasaki and the Lucky Dragon 5 incident still fresh in the Japanese consciousness, Godzilla was conceived as a metaphor for nuclear weapons.",
            };

            godzilla.PrintRep();
            Console.ReadLine();

        }
    }
}

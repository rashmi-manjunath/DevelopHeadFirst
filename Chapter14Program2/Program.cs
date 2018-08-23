using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine spot = new Canine("Spot", "pug");
            Canine bob = spot;
            bob.Name = "Spike";
            bob.Breed = "beagle";
            spot.Speak();

            Dog jake = new Dog("Jake", "Poodle");
            Dog betty = jake;
            betty.Name = "Betty";
            betty.Breed = "pit bull";
            jake.Speak();

            Console.ReadKey();
        }
    }
}

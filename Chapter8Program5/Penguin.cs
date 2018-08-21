using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Program5
{
    class Penguin : Bird
    {
        public override string ToString()
        {
            return "A penguin named " + base.Name;
        }
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }
    }
}

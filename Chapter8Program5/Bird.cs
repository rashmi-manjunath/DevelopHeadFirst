using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Program5
{
    class Bird
    {
        public string Name { get; set; }

        public  virtual void Fly()
        {
            Console.WriteLine("Flap Flap");
        }
        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }
}

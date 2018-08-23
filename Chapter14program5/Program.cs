using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14program5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman(60);
            Console.WriteLine(steve.BreakWalls(89.4));
            Console.ReadKey();

            //int[] linqtest = new int[] { 2, 5, 6 };
            //IEnumerable<int> result = from i in linqtest where i < 3 select i;
            //Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14program5
{
    static class SuperSoliderSerum
    {
        public static string BreakWalls(this OrdinaryHuman h,double wallDensity)
        {
            return ("I broke through a wall of " + wallDensity + " density.");
        }
    }
}

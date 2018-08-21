using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Program3
{
    class DuckCompareBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind > y.Kind)
                return 1;
            if (x.Kind > y.Kind)
                return -1;
            return 0;
        }
    }
}

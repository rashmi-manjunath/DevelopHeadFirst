using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Program7
{
    class JerseyNumber
    {
        public string PlayerName  { get; private set;}
        public int RetiredYear { get; private set;}
        public JerseyNumber(string playerName, int retiredYear)
        {
            PlayerName = playerName;
            RetiredYear = retiredYear;
        }
    }
}

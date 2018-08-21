using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3Program1
{
    class Talker
    {
        public static int BlahBlah(string thingTOSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingTOSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}

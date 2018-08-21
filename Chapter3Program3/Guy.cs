using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3Program2
{
    public class Guy
    {
        public string Name;
        public int Cash;

        public int giveCash(int amount)
        {
            if (amount > 0 && amount <= Cash)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(Name + "says-I dont have enough cash to give you" + amount);
                return 0;
            }
        }

        public int receiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + "itsn't an amount I'll take", Name + "says");
                return 0;
            }
        }
    }
}

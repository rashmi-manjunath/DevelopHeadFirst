using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7Program2
{
    class FunnyFunny : IClown
    {
        protected string funnyThingsIhave;
        public FunnyFunny(string funnyThingsIHave)
        {
            this.funnyThingsIhave = funnyThingsIHave;
        }
        public string FunnyThingsIHave
        {
            get
            {
                return "Honk honk! I have a " + funnyThingsIhave;
            }
        }
        public void Honk()
        {
            MessageBox.Show(this.FunnyThingsIHave); 
        }
    }
}

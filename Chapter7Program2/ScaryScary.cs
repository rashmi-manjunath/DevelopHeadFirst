using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7Program2
{
    class ScaryScary :FunnyFunny,IScaryClown
    {
         int numberOfScaryThings;
        public ScaryScary(string funnyThingsIHave, int NumberOfScaryThings):base(funnyThingsIHave)
        {
            this.numberOfScaryThings = NumberOfScaryThings;
        }
        public string ScaryThingIHave
        {
            get
            {
                return "I have " + numberOfScaryThings + " spiders";
            }
        }
        public void ScareLittleChildren()
        {
            MessageBox.Show("You can't have my "+base.funnyThingsIhave);
        //    MessageBox.Show(this.ScaryThingIHave);
        }
    }
}

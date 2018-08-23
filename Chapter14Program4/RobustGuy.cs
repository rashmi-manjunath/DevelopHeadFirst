using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14Program4
{
    class RobustGuy
    {
        public DateTime ? Birthday { get; private set; }
        public int ? Height { get; private set; }

        public RobustGuy(string birthday,string height)
        {
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
                Birthday = tempDate;
            else
                Birthday = null;

            int tempInt;
            if (int.TryParse(height, out tempInt))
                Height = tempInt;
        }
        public override string ToString()
        {
            string description;
            if (Birthday != null)
                description = "I was born on " + Birthday.Value.ToLongDateString();
            else
                description = "I dont know my birthday";
            if(Height !=null)
                description += ", and I'm " + Height + " inches tall";
            else
                description += ", and I dont know my height";
            return description;
        }
    }
}

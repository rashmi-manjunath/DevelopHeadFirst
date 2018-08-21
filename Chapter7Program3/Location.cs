using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program3
{
    abstract class Location
    {
        private string name;
        public Location[] Exists;
        public Location(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public virtual string Description
        {
            get
            {
                string description = "Yor're standing in the " + name + ". You see exits to the following places: ";
                for (int i = 0; i < Exists.Length; i++)
                {
                    description += "" + Exists[i].Name;
                    if (i != Exists.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program4
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot,string hidingPlace):base(name,hot)
        {
            this.hidingPlace = hidingPlace;
        }
        private string hidingPlace;
        public string HidingPlace
        {
            get
            {
                return hidingPlace;
            }
        }
        public override string Description
        {
            get
            {
                return base.Description + "Someone could hide " + hidingPlace + ".";
            }
        }
    }
}

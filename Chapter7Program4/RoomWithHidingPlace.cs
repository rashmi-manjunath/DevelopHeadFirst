using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program4
{
    class RoomWithHidingPlace : Room,IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration,string hidingPlace):base(name,decoration)
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
                return base.Description + "someone could hide " + hidingPlace + " .";
            }
        }
    }
}

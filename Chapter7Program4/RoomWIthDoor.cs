using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program4
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        private string doorDescription;
        private string hidingPlace;
        public RoomWithDoor(string name, string decoration,string hidingPlace, string doorDescription) : base(name, decoration,hidingPlace)
        {
            this.doorDescription = doorDescription;
        }

        public string DoorDescription
        {
            get
            {
                return doorDescription;
            }
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get
            {
                return doorLocation;
            }

            set
            {
                doorLocation = value;
            }
        }

    }

}

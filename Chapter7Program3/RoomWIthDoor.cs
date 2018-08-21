﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program3
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        private string doorDescription;
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
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

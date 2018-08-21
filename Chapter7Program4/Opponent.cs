using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program4
{
    class Opponent
    {
       private Location myLocation;
       private Random random;

       public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }
        public void Move()
        {
            if(myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;

                if (random.Next(2) == 1)
                    myLocation = LocationWithDoor.DoorLocation;
            }
            bool hidden = false;
            while (!hidden)
            {
                int rand = random.Next(myLocation.Exists.Length);
                myLocation = myLocation.Exists[rand];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }
        public bool Check(Location locationToCheck)
        {
            if (locationToCheck != myLocation)
                return true;
            else
                return false;
        }
    }
}

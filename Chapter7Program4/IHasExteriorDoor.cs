﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Program4
{
    interface IHasExteriorDoor
    {
     string DoorDescription { get; }
     Location DoorLocation { get; set; }
    }
}

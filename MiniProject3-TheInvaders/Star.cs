using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniProject3_TheInvaders
{
    struct Star
    {
        public Point point;
        public Brush brush;

        public Star(Point point,Brush brush)
        {
            this.point = point;
            this.brush = brush;
        }
    }
}

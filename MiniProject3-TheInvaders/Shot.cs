using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3_TheInvaders
{
    class Shot
    {
        private const int MOVEINTERVAL = 15;
        private const int WIDTH = 3;
        private const int HEIGHT = 10;

        public Point Location { get; private set; }

        private Rectangle boundaries;
        private Direction direction;

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Red, Location.X, Location.Y, WIDTH, HEIGHT);
        }

        public bool Move()
        {
            Point newLocation;
            if(direction==Direction.Down)
            {
                newLocation = new Point(Location.X, (Location.Y + MOVEINTERVAL));
            }
            else
            {
                newLocation = new Point(Location.X, (Location.Y - MOVEINTERVAL));
            }
            if ((newLocation.Y < boundaries.Height) && (newLocation.Y > 0))
            {
                Location = newLocation;
                return true;
            }
            else
                return false;
        }
    }
}

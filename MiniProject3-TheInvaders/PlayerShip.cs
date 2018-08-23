using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3_TheInvaders
{

    class PlayerShip
    {
        private const int HORIZONTAL_INTERVAL = 10;

        private bool alive;
        private DateTime deathWait;
        private Rectangle boundaries;
        private float deadShipHeight;
        
        public Point Location { get; private set; }
        public Bitmap image = Properties.Resources.player;


        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }
      
        public PlayerShip(Rectangle boundaries, Point location)
        {
            this.boundaries = boundaries;
            this.Location = location;
            Alive = true;
            deadShipHeight = 1.0F;
        }

        public bool Alive
        {
            get
            {
                return alive;
            }
            set
            {
                alive = value;
                if (!value)
                    deathWait = DateTime.Now;
            }
        }

      
        public void Draw(Graphics graphics)
        {
            if (!Alive)
            {
                if ((DateTime.Now - deathWait) > TimeSpan.FromSeconds(1.5))
                {
                    deadShipHeight = 0.0F;
                    Alive = true;
                }
                else if ((DateTime.Now - deathWait) > TimeSpan.FromSeconds(1))
                {
                    deadShipHeight = 0.25F;
                }
                else if ((DateTime.Now - deathWait) > TimeSpan.FromSeconds(0.5))
                {
                    deadShipHeight = 0.75F;
                }
                else if ((DateTime.Now - deathWait) > TimeSpan.FromSeconds(0))
                {
                    deadShipHeight = 0.9F;
                }

                graphics.DrawImage(image, (float)Location.X, (float)Location.Y,
                        (float)image.Width, (image.Height * deadShipHeight));

            }
            else
            {
                graphics.DrawImage(image, Location);
            }
        }

        public void Move(Direction direction)
        {
            if(Alive)
            {
                if(direction == Direction.Left)
                {
                    Point newLocation = new Point((Location.X - HORIZONTAL_INTERVAL), Location.Y);
                    if ((newLocation.X < (boundaries.Width - 100)) && (newLocation.X > 50))
                        Location = newLocation;
                }
                else if(direction==Direction.Right)
                {
                    Point newLocation = new Point((Location.X + HORIZONTAL_INTERVAL), Location.Y);
                    if ((newLocation.X < (boundaries.Width - 100)) && (newLocation.X > 50))
                        Location = newLocation;
                }
            }
        }
    }

}

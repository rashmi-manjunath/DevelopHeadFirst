using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject3_TheInvaders
{
    class Invaders
    {
        private const int HORIZONTAL_INTERVAL = 10;
        private const int VERTICAL_INTERVAL = 40;

        private Bitmap image;
        private Bitmap[] invaderImage;
        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }

        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }
        public int Score
        {
            get;private set;
        }
        public Invaders(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            CreateInvader();
            image = invaderImage[0];
        }

        public Graphics Draw(Graphics graphics, int animationCell)
        {
            Graphics invaderGraphics = graphics;
            image = invaderImage[animationCell];
            try
            {
                graphics.DrawImage(image, Location);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return invaderGraphics;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    Location = new Point((Location.X + HORIZONTAL_INTERVAL), Location.Y);
                    break;
                case Direction.Left:
                    Location = new Point((Location.X - HORIZONTAL_INTERVAL), Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, (Location.Y + VERTICAL_INTERVAL));
                    break;
            }
        }

        private void CreateInvader()
        {
            invaderImage = new Bitmap[4];
            switch(InvaderType)
            {
                case ShipType.Bug:
                    invaderImage[0] = Properties.Resources.bug1;
                    invaderImage[1] = Properties.Resources.bug2;
                    invaderImage[2] = Properties.Resources.bug3;
                    invaderImage[3] = Properties.Resources.bug4;
                    break;
                case ShipType.Satellite:
                    invaderImage[0] = Properties.Resources.satellite1;
                    invaderImage[1] = Properties.Resources.satellite2;
                    invaderImage[2] = Properties.Resources.satellite3;
                    invaderImage[3] = Properties.Resources.satellite4;
                    break;
                case ShipType.Saucer:
                    invaderImage[0] = Properties.Resources.flyingsaucer1;
                    invaderImage[1] = Properties.Resources.flyingsaucer2;
                    invaderImage[2] = Properties.Resources.flyingsaucer3;
                    invaderImage[3] = Properties.Resources.flyingsaucer4;
                    break;
                case ShipType.Spaceship:
                    invaderImage[0] = Properties.Resources.spaceship1;
                    invaderImage[1] = Properties.Resources.spaceship2;
                    invaderImage[2] = Properties.Resources.spaceship3;
                    invaderImage[3] = Properties.Resources.spaceship4;
                    break;
                case ShipType.Star:
                    invaderImage[0] = Properties.Resources.star1;
                    invaderImage[1] = Properties.Resources.star2;
                    invaderImage[2] = Properties.Resources.star3;
                    invaderImage[3] = Properties.Resources.star4;
                    break;
            }
        }
    }
}

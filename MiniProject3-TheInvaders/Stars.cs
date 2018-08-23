using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3_TheInvaders
{
    class Stars
    {
        private List<Star> stars;
        private Rectangle formArea;

        public Stars(Random random, Rectangle formArea)
        {
            this.formArea = formArea;
            stars = new List<Star>();
            for (int i = 1; i < 300; i++)
                addStar(random);
        }

        private void addStar(Random random)
        {
            int height = formArea.Height;
            int width = formArea.Width;
            Point location = new Point(random.Next(0, width), random.Next(0, height));
            Star newStar = new Star(location, Brushes.Yellow);
            stars.Add(newStar);
        }

        public Graphics Draw(Graphics graphics)
        {
            Graphics starGraphics = graphics;
            foreach (Star Star in stars)
            {
                starGraphics.FillRectangle(Star.brush, Star.point.X, Star.point.Y, 1, 1);
            }
            return starGraphics;
        }

        public void Twinkle(Random random)
        {
            stars.RemoveRange(0, 5);
            for (int i = 0; i < 5; i++)
                addStar(random);
        }
    }
}

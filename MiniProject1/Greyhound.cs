using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniProject1
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;

        public Random Randomizer;

        public bool Run()
        {
            Randomizer = new Random();
            int distance = Randomizer.Next(1, 5);

            MoveMyPictureBox(distance);

            Location += distance;
            if(Location >= (RacetrackLength-StartingPosition))
            {
                return true;
            }
            return false;
        }

        private void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
        }

        public void TakeStartPosition()
        {
            Location = 0;
        }
    }
}

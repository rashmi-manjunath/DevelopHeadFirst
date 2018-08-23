using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11Program1
{
    class Picture
    {
        public Picture(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

        private void ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    catchBall();
                else
                    coverFirstBase();
            }
        }
        private void coverFirstBase()
        {
            Console.WriteLine("Pitcher : I caught the ball");
        }
        private void catchBall()
        {
            Console.WriteLine("Pitcher : I covered the first base");
        }
    }
}

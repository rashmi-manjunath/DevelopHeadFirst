using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form1 : Form
    {

        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public Form1()
        {
            InitializeComponent();
            SetupRace();
        }

        private void SetupRace()
        {
            MiniumBet.Text = string.Format("Minimum bet {0:c}", (int)BetAmount.Minimum);

            int startingPosition = dog1.Right - racetrack.Left;
            int raceTrackLength = racetrack.Size.Width;

            dogs[0] = new Greyhound() { MyPictureBox = dog1, RacetrackLength = raceTrackLength, StartingPosition = startingPosition };
            dogs[1] = new Greyhound() { MyPictureBox = dog2, RacetrackLength = raceTrackLength, StartingPosition = startingPosition };
            dogs[2] = new Greyhound() { MyPictureBox = dog3, RacetrackLength = raceTrackLength, StartingPosition = startingPosition };
            dogs[3] = new Greyhound() { MyPictureBox = dog4, RacetrackLength = raceTrackLength, StartingPosition = startingPosition };

            guys[0] = new Guy("Joe", null, 50, Joe, joesBet);
            guys[1] = new Guy("Bob", null, 75, Bob, bobsBet);
            guys[2] = new Guy("Al", null, 45, Al, alsBet);

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }
        }

        private void Joe_CheckedChanged(object sender, EventArgs e)
        {
            bettor.Text = "Joe";
        }

        private void Bob_CheckedChanged(object sender, EventArgs e)
        {
            bettor.Text = "Bob";
        }

        private void Al_CheckedChanged(object sender, EventArgs e)
        {
            bettor.Text = "Al";
        }

        private void Bets_Click(object sender, EventArgs e)
        {
            if (Joe.Checked)
            {
                guys[0].PlaceBet((int)BetAmount.Value, (int)DogNumber.Value);
                guys[0].UpdateLabels();
            }
            if (Bob.Checked)
            {
                guys[1].PlaceBet((int)BetAmount.Value, (int)DogNumber.Value);
                guys[1].UpdateLabels();
            }
            if (Al.Checked)
            {
                guys[2].PlaceBet((int)BetAmount.Value, (int)DogNumber.Value);
                guys[2].UpdateLabels();
            }
        }

        private void race_Click(object sender, EventArgs e)
        {
            race.Enabled = false;
            bool NoWinner = true;
            int winningDog;

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < dogs.Length; i++)
                {
                    if (dogs[i].Run())
                    {
                        winningDog = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner  - Dog " + winningDog);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)
                            {
                                guy.COllect(winningDog);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }
                        foreach (Greyhound dog in dogs)
                        {
                            dog.TakeStartPosition();
                        }
                        break;
                    }
                }
            }
            race.Enabled = true;
            Application.Exit();
        }
    }
}


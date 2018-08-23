using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject3_TheInvaders
{
    public partial class Form1 : Form
    {
        public int Frame = 0;
        private Game game;
        Random random = new Random();
        public Rectangle FormArea { get { return this.ClientRectangle; } }

        List<Keys> keysPressed = new List<Keys>();
        private bool gameOver;

        public Form1()
        {
            InitializeComponent();
            Frame = 0;
            game = new Game(random, FormArea);
            gameOver = false;
            game.GameOver += new EventHandler(game_GameOver);
            animationTimer.Start();
        }
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (Frame < 3)
                Frame++;
            else
                Frame = 0;
            game.Twinkle();
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();
                if (e.KeyCode == Keys.S)
                {
                    gameOver = false;
                    game = new Game(random, FormArea);
                    game.GameOver += new EventHandler(game_GameOver);
                    gameTimer.Start();
                    return;
                }
            if (e.KeyCode == Keys.Space)
                game.FireShot();
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void game_GameOver(object sender,EventArgs e)
        {
            gameTimer.Stop();
            gameOver = true;
            Invalidate();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();
            foreach(Keys key in keysPressed)
            {
                if(key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left,gameOver);
                    return;
                }
                else if(key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right,gameOver);
                    return;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            game.Draw(graphics, Frame, gameOver);
        }
    }
}

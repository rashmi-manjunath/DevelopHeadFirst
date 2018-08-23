using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MiniProject3_TheInvaders
{
    class Game
    {
        private const int INVADERXSPACING = 60;
        private const int INVADERYSPACING = 60;

        private int score = 0;
        private int livesLeft = 5;
        private int wave = 0;
        private int framesSkipped = 6;
        private int currentGameFrame = 1;

        private Rectangle formArea;
        private Random random;

        private Direction invaderDirection;
        private List<Invaders> invaders;

        private PlayerShip playership;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private PointF scoreLocation;
        private PointF livesLocation;
        private PointF waveLocation;

        Font statsFont = new Font(FontFamily.GenericMonospace, 15);
        Font messageFont = new Font(FontFamily.GenericMonospace, 15);

        private Stars stars;

        public event EventHandler GameOver;

        public Game(Random random, Rectangle formArea)
        {
            this.random = random;
            this.formArea = formArea;
            stars = new Stars(random, formArea);
            scoreLocation = new PointF((formArea.Left + 5.0F), (formArea.Top + 5.0F));
            livesLocation = new PointF((formArea.Right - 120.0F), (formArea.Top + 5.0F));
            waveLocation = new PointF((formArea.Left + 5.0F), (formArea.Top + 25.0F));
            playership = new PlayerShip(formArea, new Point((formArea.Width / 2), (formArea.Height - 50)));
            playerShots = new List<Shot>();
            invaderShots = new List<Shot>();
            invaders = new List<Invaders>();
            nextWave();
        }

        private void nextWave()
        {
            wave++;
            invaderDirection = Direction.Right;
            if (wave < 7)
            {
                framesSkipped = 6 - wave;
            }
            else
                framesSkipped = 0;

            int currentInvaderYSpace = 0;
            for (int x = 0; x < 5; x++)
            {
                ShipType currentInvaderType = (ShipType)x;
                currentInvaderYSpace += INVADERYSPACING;

                int currentInavderXSpace = 0;
                for (int y = 0; y < 5; y++)
                {
                    currentInavderXSpace += INVADERXSPACING;
                    Point newInvaderPoint = new Point(currentInavderXSpace, currentInvaderYSpace);
                    Invaders newInvader = new Invaders(currentInvaderType, newInvaderPoint, 10);
                    invaders.Add(newInvader);
                }
            }
        }

        public void Twinkle()
        {
            stars.Twinkle(random);
        }
        public void MovePlayer(Direction direction, bool gameOver)
        {
            if (!gameOver)
            {
                playership.Move(direction);
            }
        }

        public void FireShot()
        {
            if (playerShots.Count < 2)
            {
                Shot newShot = new Shot(
                    new Point((playership.Location.X + (playership.image.Width / 2))
                        , playership.Location.Y),
                    Direction.Up, formArea);
                playerShots.Add(newShot);
            }
        }

        public void Go()
        {
            if (playership.Alive)
            {
                List<Shot> deadPlayerShots = new List<Shot>();
                foreach (Shot shot in playerShots)
                {
                    if (!shot.Move())
                        deadPlayerShots.Add(shot);
                }
                foreach (Shot shot in deadPlayerShots)
                    playerShots.Remove(shot);

                List<Shot> deadInvaderShots = new List<Shot>();
                foreach (Shot shot in invaderShots)
                {
                    if (!shot.Move())
                        deadInvaderShots.Add(shot);
                }
                foreach (Shot shot in deadInvaderShots)
                    invaderShots.Remove(shot);
                moveInvader();
                returnFire();
                checkForCollisions();
                if (invaders.Count < 1)
                {
                    nextWave();
                }
            }

        }

        private void checkForCollisions()
        {
            List<Shot> deadPlayerShots = new List<Shot>();
            List<Shot> deadInvaderShots = new List<Shot>();

            foreach(Shot shot in invaderShots)
            {
                if(playership.Area.Contains(shot.Location))
                {
                    deadInvaderShots.Add(shot);
                    livesLeft--;
                    playership.Alive = false;
                    if (livesLeft == 0)
                        GameOver(this, null);
                }
            }

            foreach (Shot shot in playerShots)
            {
                List<Invaders> deadInvaders = new List<Invaders>();
                foreach (Invaders invader in invaders)
                {
                    if (invader.Area.Contains(shot.Location))
                    {
                        deadInvaders.Add(invader);
                        deadInvaderShots.Add(shot);
                        score = score + (1 * wave);
                    }
                }
                foreach (Invaders invader in deadInvaders)
                    invaders.Remove(invader);
            }
            foreach (Shot shot in deadPlayerShots)
                playerShots.Remove(shot);
            foreach (Shot shot in deadInvaderShots)
                invaderShots.Remove(shot);
        }

        private void returnFire()
        {
            if (invaderShots.Count == wave)
                return;
            if (random.Next(10) < (10 - wave))
                return;

            var invaderColumns = from invader in invaders
                                 group invader by invader.Location.X into columns
                                 select columns;

            int randomColumnNumber = random.Next(invaderColumns.Count());
            var randomColumn = invaderColumns.ElementAt(randomColumnNumber);

            var invaderRow = from invader in randomColumn
                             orderby invader.Location.Y descending
                             select invader;
            Invaders shooter = invaderRow.First();
            Point newShotLocation = new Point(shooter.Location.X + (shooter.Area.Width / 2), shooter.Location.Y+shooter.Area.Height);

            Shot newShot = new Shot(newShotLocation, Direction.Down, formArea);
            invaderShots.Add(newShot);
        }

        private void moveInvader()
        {
            if (currentGameFrame > framesSkipped)
            {
                if (invaderDirection == Direction.Right)
                {
                    var edgeInvaders = from invader in invaders
                                       where invader.Location.X > (formArea.Width - 100)
                                       select invader;
                    if (edgeInvaders.Count() > 0)
                    {
                        invaderDirection = Direction.Left;
                        foreach (Invaders invader in invaders)
                            invader.Move(Direction.Down);
                    }
                    else
                    {
                        foreach (Invaders invader in invaders)
                            invader.Move(Direction.Right);
                    }
                }
                if (invaderDirection == Direction.Left)
                {
                    var edgeInvaders = from invader in invaders
                                       where invader.Location.X < 100
                                       select invader;
                    if (edgeInvaders.Count() > 0)
                    {
                        invaderDirection = Direction.Right;
                        foreach (Invaders invader in invaders)
                            invader.Move(Direction.Down);
                    }
                    else
                    {
                        foreach (Invaders invader in invaders)
                            invader.Move(Direction.Left);
                    }
                }
                var endInvaders = from invader in invaders
                                  where invader.Location.Y > playership.Location.Y
                                  select invader;
                if(endInvaders.Count()>0)
                {
                    GameOver(this, null);
                }
                foreach(Invaders invader in invaders)
                {
                    invader.Move(invaderDirection);
                }
            }
            currentGameFrame++;
            if (currentGameFrame > 6)
                currentGameFrame = 1;
        }

        public void Draw(Graphics graphics, int frame, bool gameOver)
        {
            graphics.FillRectangle(Brushes.Black, formArea);
            stars.Draw(graphics);
            foreach (Invaders invader in invaders)
                invader.Draw(graphics, frame);
            playership.Draw(graphics);
            foreach (Shot shot in playerShots)
                shot.Draw(graphics);
            foreach (Shot shot in invaderShots)
                shot.Draw(graphics);

            graphics.DrawString(("Score: " + score.ToString()), statsFont, Brushes.Yellow, scoreLocation);
            graphics.DrawString(("Lives: " + livesLeft.ToString()), statsFont, Brushes.Yellow, livesLocation);
            graphics.DrawString(("Wave: " + wave.ToString()), statsFont, Brushes.Yellow, waveLocation);
            if (gameOver)
            {
                graphics.DrawString("GAME OVER", messageFont, Brushes.Red, (formArea.Width / 4), (formArea.Height / 3));
            }
        }
    }
}
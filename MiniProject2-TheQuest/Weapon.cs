﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2_TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp
        {
            get;private set;
        }
        private Size pictureBoxSize = new Size(50, 50);
        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }
        public void PickUpWeapon()
        {
            PickedUp = true;
        }
        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation, enemy, direction, (radius / 2)))
                {
                    enemy.Hit(damage, random);
                    return true;
                }
            }
            return false;
        }
        private bool Nearby(Point playerLocation, Enemy enemy, Direction direction, int distance)
        {
            bool nearBy = false;

            Rectangle enemyBoundary = new Rectangle(enemy.Location, pictureBoxSize);
            Rectangle playerAttackArea = new Rectangle();

            switch (direction)
            {
                case Direction.Up:
                    playerAttackArea.Location = new Point(playerLocation.X, playerLocation.Y - distance);
                    playerAttackArea.Width = pictureBoxSize.Width;
                    playerAttackArea.Height = distance;
                    break;
                case Direction.Right:
                    playerAttackArea.Location = new Point(playerLocation.X + pictureBoxSize.Width, playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = pictureBoxSize.Height;
                    break;
                case Direction.Down:
                    playerAttackArea.Location = new Point(playerLocation.X, playerLocation.Y + pictureBoxSize.Height);
                    playerAttackArea.Width = pictureBoxSize.Width;
                    playerAttackArea.Height = distance;
                    break;
                case Direction.Left:
                    playerAttackArea.Location = new Point(playerLocation.X + distance, playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = pictureBoxSize.Height;
                    break;
            }
            if (playerAttackArea.IntersectsWith(enemyBoundary))
                nearBy = true;

            return nearBy;
        }
        private Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            target = Move(direction, boundaries);
            return target;
        }

        protected Direction ClockwiseDirection(Direction direction)
        {
            Direction clockWiseDirection = direction;

            switch (direction)
            {
                case Direction.Up:
                    clockWiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    clockWiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    clockWiseDirection = Direction.Left;
                    break;
                case Direction.Left:
                    clockWiseDirection = Direction.Up;
                    break;
            }

            return clockWiseDirection;
        }

        protected Direction CounterClockwiseDirection(Direction direction)
        {
            Direction counterClockWiseDirection = direction;

            switch (direction)
            {
                case Direction.Up:
                    counterClockWiseDirection = Direction.Left;
                    break;
                case Direction.Right:
                    counterClockWiseDirection = Direction.Up;
                    break;
                case Direction.Down:
                    counterClockWiseDirection = Direction.Right;
                    break;
                case Direction.Left:
                    counterClockWiseDirection = Direction.Down;
                    break;
            }

            return counterClockWiseDirection;
        }

    }
}

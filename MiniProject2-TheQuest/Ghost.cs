﻿using System;
using System.Drawing;

namespace MiniProject2_TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location):base(game,location,8)
        {
        }
        public override void Move(Random random)
        {
            if (random.Next(1, 3) == 1 && HitPoints > 0)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
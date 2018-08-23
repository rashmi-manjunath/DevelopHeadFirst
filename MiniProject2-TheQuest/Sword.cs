using System;
using System.Drawing;

namespace MiniProject2_TheQuest
{
    class Sword : Weapon
    {
        private const int ATTACKRADIUS = 20;
        private const int DAMAGE = 3;

        public Sword(Game game, Point location) :base(game,location)
        {
        }
        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            if(!DamageEnemy(direction,ATTACKRADIUS,DAMAGE,random))
            {
                if(!DamageEnemy(ClockwiseDirection(direction),ATTACKRADIUS,DAMAGE,random))
                {
                    DamageEnemy(CounterClockwiseDirection(direction), ATTACKRADIUS, DAMAGE, random);
                }
            }

        }
    }
}
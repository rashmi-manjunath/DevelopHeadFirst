using System;
using System.Drawing;

namespace MiniProject2_TheQuest
{
    class Bow : Weapon
    {
        private const int ATTACKRADIUS = 30;
        private const int DAMAGE = 1;
        public Bow(Game game, Point location):base(game,location)
        {
        }

        public override string Name
        {
            get
            {
                return "Bow";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, ATTACKRADIUS, DAMAGE, random))
            {
                if (!DamageEnemy(ClockwiseDirection(direction), ATTACKRADIUS, DAMAGE, random))
                {
                    DamageEnemy(CounterClockwiseDirection(direction), ATTACKRADIUS, DAMAGE, random);
                }
            }
        }
    }
}
using System;
using System.Drawing;

namespace MiniProject2_TheQuest
{
    class Mace : Weapon
    {
        private const int ATTACKRADIUS = 40;
        private const int DAMAGE = 6;

        public Mace(Game game, Point location):base(game,location)
        {
        }

        public override string Name
        {
            get
            {
                return "Mace";
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
using System;
using System.Drawing;

namespace MiniProject2_TheQuest
{
    class BluePotion : Weapon,IPotion
    {
        public BluePotion(Game game, Point location):base(game,location)
        {
            Used = false;
        }

        public override string Name
        {
            get
            {
                return "Blue Potion";
            }
        }
        public bool Used
        {
            get;private set;
        }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }
    }
}
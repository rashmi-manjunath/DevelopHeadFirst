using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(int Amount,int Dog,Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }
        public string GetDescription()
        {
            string description = "";

            if(Amount>0)
            {
                description = Bettor.Name + "bets " + this.Amount + " on dog " + this.Dog;
                return description;
            }
            else
            {
                description = Bettor.Name + " hasn't placed any bets";
            }
            return description;
        }
        public int PayOut(int Winner)
        {
            if(Winner == Dog)
            {
                int winAmount = Amount * 2;
                return winAmount;
            }
            else
            {
                return -1 * Amount;
            }
        }
    }
}

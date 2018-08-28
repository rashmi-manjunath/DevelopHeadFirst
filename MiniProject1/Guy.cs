using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy(string Name, Bet MyBet,int Cash,RadioButton MyRadioButton,Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }
        public void UpdateLabels()
        {
            if(MyBet== null)
            {
                MyLabel.Text = string.Format("{0} hasn't placed any bets ", Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks ";
        }
        public bool PlaceBet(int Amount,int Dog)
        {
            if(Amount <= Cash)
            {
                MyBet = new Bet(Amount, Dog, this);
                return true;
            }
            return false;
        }
        public void COllect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }
    }
}

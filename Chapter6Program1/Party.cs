using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Program1
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecoration = 0;
        private bool fancyDecorations;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            this.NumberOfPeople = numberOfPeople;
        }
        private int numberOfPeople;
        public virtual int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecoration = (NumberOfPeople * 15.00M) + 50;
            }
            else
            {
                CostOfDecoration = (NumberOfPeople * 7.50M) + 30;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecoration + (CostOfFoodPerPerson * numberOfPeople);

            if (NumberOfPeople > 12)
            {
                TotalCost += 100;
            }
            return TotalCost;
        }
    }
}

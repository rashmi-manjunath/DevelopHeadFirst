using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Program1
{
    class DinnerParty
    {
        const int CosOfFoodPerPerson = 25;
        
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        private int numberOfPeople;
        public int NumberOfPeople
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
        public DinnerParty(int numberOfPeople,bool healthOption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthOption)
        {
            if(healthOption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }
        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            if(fancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthOption)
        {
            decimal TotalCost = CostOfDecorations + (CostOfBeveragesPerPerson * NumberOfPeople);
           
            if(healthOption)
            {
                return TotalCost * 0.95M;
            }
            else
            {
                return TotalCost;
            }
        }

     
    }
}

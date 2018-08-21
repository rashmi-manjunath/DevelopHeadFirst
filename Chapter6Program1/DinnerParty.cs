using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Program1
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }
        public void SetHealthyOption(bool healthOption)
        {
            if (healthOption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }
        public decimal CalculateCost(bool healthOption)
        {
            decimal TotalCost;
            TotalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);

            if (healthOption)
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

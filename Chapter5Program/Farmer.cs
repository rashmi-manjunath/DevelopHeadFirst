using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Program
{
    class Farmer
    {
        private int numberOfCows;

        public int FeedMultiplier { get; private set; }
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
        public int BagsOfFeed { get; private set; }

        public Farmer(int numberOfCows,int feedMultiplier)
        {
            FeedMultiplier = feedMultiplier;
            this.NumberOfCows = numberOfCows;
        }
    }
}

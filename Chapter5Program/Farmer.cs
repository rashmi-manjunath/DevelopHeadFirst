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

        private int feedMultiplier;
        //public int FeedMultiplier
        //{
        //    get
        //    {
        //        return feedMultiplier;
        //    }
        //}
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * feedMultiplier;
            }
        }
        public int BagsOfFeed { get; private set; }

        public Farmer(int numberOfCows,int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}

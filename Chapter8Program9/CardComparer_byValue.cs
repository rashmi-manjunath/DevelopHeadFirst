using System;
using System.Collections.Generic;

namespace Chapter8Program9
{
    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            //if (x.Suit > y.Suit)
            //    return 1;
            //if (x.Suit < y.Suit)
            //    return -1;
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            return 0;        }
    }
}
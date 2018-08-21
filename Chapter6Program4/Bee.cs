using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Program4
{
    class Bee
    {
        private double weight;
        public Bee(double weight)
        {
            this.weight = weight;
        }
        public virtual int ShiftLeft
        {
            get
            {
                return 0;
            }
        }
        public virtual double getHoneyConsumption()
        {
            double consumption = 0;
            if (ShiftLeft == 0)
                consumption += 7.5;
            else
                consumption = 9 + ShiftLeft;
            if (weight > 150)
                consumption *= 1.35;
            return consumption;
        }
    }
}



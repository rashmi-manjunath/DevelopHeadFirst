using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12Program1
{
    [Serializable]
    public class Flower
    {
        private const int LifeSpanMin = 15000;
        private const int LifeSpanMax = 30000;
        private const double InitialNectar = 1.5;
        private const double MaxNectar = 5;
        private const double NectarAddedPerTurn = 0.01;
        private const double NectarGatheredPerTurn = 0.3;

        //read-only properties
        public Point Location { get; private set; }
        public double Age { get; private set; }
        public bool Alive { get; private set; }
        public double Nectar { get; private set; }
        public double NectarHarvested { get; set; }

        private int lifeSpan;

        public Flower(Point location,Random random)
        {
            Location = location;
            Age = 0;
            Alive = true;
            Nectar = 1.5;
            NectarHarvested = 0; ;
            lifeSpan = random.Next(LifeSpanMin, LifeSpanMax + 1);
        }
        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
                return 0;
            else
                Nectar -= NectarGatheredPerTurn;
                NectarHarvested += NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
        }
        public void Go()
        {
            Age++;
            if (Age > lifeSpan)
                Alive = false;
            else
            {
                Nectar += NectarAddedPerTurn;
                if (Nectar > MaxNectar)
                    Nectar = MaxNectar;
            }
        }
    }
}

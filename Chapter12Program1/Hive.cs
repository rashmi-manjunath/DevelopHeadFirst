using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chapter12Program1
{
    [Serializable]
    public class Hive
    {
        private const int InitialNumberOfBees = 6;
        private const double InitialHoney = 3.2;
        private const double MaxHoney = 15;
        private const double NectarHoneyRatio = .25;
        private const int MaxNumberOfBees = 8;
        private const double MinHoneyForCreatingBees = 4;
        public double Honey { get;  private set; }
        private Dictionary<string, Point> locations;
        private int beeCount = 0;
        private World world;

        
        public Bee.BeeMessage MessageSender;
        public void InitialLocations()
        {
            locations = new Dictionary<string, Point>();
            locations.Add("Entrance", new Point(650, 100));
            locations.Add("Nursery", new Point(95, 174));
            locations.Add("HoneyFactory", new Point(157, 98));
            locations.Add("Exit", new Point(201, 213));
        } 
        public Point GetLocations(string location)
        {
            if (locations.Keys.Contains(location))
                return locations[location];
            else
                throw new ArgumentException("Unknown Location : " + location);
        }

        public Hive(World world,Bee.BeeMessage MessageSender)
        {
            this.world = world;
            this.MessageSender = MessageSender;
            Honey = InitialHoney;
            InitialLocations();
            Random random = new Random();
            for (int i = 0; i < InitialNumberOfBees; i++)
                AddBee(random);
        }
        public bool AddHoney(double nectar)
        {
            double honeyToAdd = nectar * NectarHoneyRatio;
            if (honeyToAdd + Honey > MaxHoney)
                return false;
            Honey += honeyToAdd;
            return true;
        }
        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey)
                return false;
            else
            {
                Honey -= amount;
                return true;
            }
        }
        private void AddBee(Random random)
        {
            beeCount++;
            int r1 = random.Next(100) - 50;
            int r2 = random.Next(100) - 50;
            Point startPoint = new Point(locations["Nursery"].X + r1, locations["Nursery"].Y + r2);

            Bee newBee = new Bee(beeCount, startPoint,world,this);
            newBee.MessageSender += this.MessageSender;
            world.Bees.Add(newBee);
        }
        public void Go(Random random)
        {
            if (world.Bees.Count < MaxNumberOfBees && Honey > MinHoneyForCreatingBees && random.Next(10)==1)
                AddBee(random);
        }
    }
}

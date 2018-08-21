using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Program3
{
    class MenuMaker
    {
        public Random Randomnizer = new Random();

        string[] meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        string[] breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string getMenuItem()
        {
            string randomMeat = meats[Randomnizer.Next(meats.Length)];
            string randomCondiment = condiments[Randomnizer.Next(condiments.Length)];
            string randomBread = breads[Randomnizer.Next(breads.Length)];

            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}

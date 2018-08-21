﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chapter8Program3
{
    class Program : Duck
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard,Size=17 },
                new Duck() {Kind = KindOfDuck.Muscovy,Size=18 },
                new Duck() {Kind = KindOfDuck.Decoy,Size=14 },
                new Duck() {Kind = KindOfDuck.Muscovy,Size=11 },
                new Duck() {Kind = KindOfDuck.Mallard,Size=14 },
                new Duck() {Kind = KindOfDuck.Decoy,Size=13 },
            };
            // ducks.Sort();
            DuckCompareBySize compareOfDucks = new DuckCompareBySize();
            ducks.Sort(compareOfDucks);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.ToString());
            }
            Console.ReadLine();
        }
    }
}

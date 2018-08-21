using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, Color = "Brownn" });
            shoeCloset.Add(new Shoe() { Style = Style.Wingtips, Color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "White" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "Red" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset) 
            {
                //shoe.Style = Style.Flipflops;
                //shoe.Color = "Orange";
                Console.Write(shoe.Style + " " + shoe.Color);
                Console.ReadLine();
            }
        }
    }
}

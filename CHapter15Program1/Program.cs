using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHapter15Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactsDBDataContext context = new ContactsDBDataContext();

            var peopleData = from people in context.Peoples
                             select new { people.ContactId, people.Name };

            foreach (var person in peopleData)
                Console.WriteLine("I'm {0} and my ID is {1} ", person.Name, person.ContactId);
            Console.ReadKey();

            //List<Starbuzz> starbuzzList = GetStarbuzzData();

            //var results =
            //              from starbuzzCustomer in starbuzzList
            //              where starbuzzCustomer.MoneySpent > 90
            //              join People in context.Peoples
            //              on starbuzzCustomer.Name equals People.Name
            //              select new { People.Name, starbuzzCustomer.FavoriteDrink };
            //foreach (var row in results)
            //    Console.WriteLine("{0} likes {2}", row.Name, row.FavoriteDrink);
        }

        static List<Starbuzz> GetStarbuzzData()
        {
            return new List<Starbuzz>
           {
               new Starbuzz
               {
                   Name = "Arun" , FavoriteDrink =Drink.ChocoMacchitato ,MoneySpent =255,Visits =50
               },
               new Starbuzz
               {
                   Name ="Chetan" , FavoriteDrink = Drink.BoringCoffe , MoneySpent = 150 ,Visits= 35
               },
               new Starbuzz
               {
                   Name = "Bharani" , FavoriteDrink =Drink.TripleEspresso , MoneySpent =154,Visits =10
               }
           };
        }
    }
}

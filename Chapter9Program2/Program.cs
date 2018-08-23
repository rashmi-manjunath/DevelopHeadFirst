using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter9Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //using StreamWriter object

            //StreamWriter sw = new StreamWriter(@"C:\Users\Rashmi\Documents\secret_plan.txt", false);
            //sw.WriteLine("How I'll defeat Captian Amazing ");
            //sw.WriteLine("Another genius secreatplan by the Swindler");
            //sw.Write("I'll Create an army of clones and ");
            //sw.WriteLine("unleash them upon the citizens.");

            //string location = "the mall";

            //for(int number=0;number <=6; number++)
            //{
            //    sw.WriteLine("Clone #{0} attacks {1}", number, location);
            //    if(location=="the mall")
            //    {
            //        location = "dowmtown";
            //    }
            //    else
            //    {
            //        location = "the mall";
            //    }
            //}
            //sw.Close();

            //using both StreamReader and StreamWriter

            using (StreamReader reader = new StreamReader(@"C:\Users\Rashmi\Documents\secret_plan.txt"))
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Rashmi\Documents\writingToThisFile.txt"))
            {
                writer.WriteLine("To : Captain@gmail.com");
                writer.WriteLine("From : Commissioner@gmail.com");
                writer.WriteLine();
                writer.WriteLine("Subject : Can you save the day .. again?");
                writer.WriteLine();
                writer.WriteLine("We've discover the Swindler's plan :");
                while (!reader.EndOfStream)
                {
                    string lineFromThePlan = reader.ReadLine();
                    writer.WriteLine(lineFromThePlan);
                }
                writer.WriteLine();
            }
        }

        
    }
}

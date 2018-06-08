using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page71
{
    class Program
    {
        static void Main(string[] args)
        {
            const int answerToLifeTheUniverseAndEverything= 42;

            var TonyIommi = new Human(string FirstName, string LastName, int NumberOfFingers);
            TonyIommi.FirstName = "Anthony";
            TonyIommi.LastName = "Iommi";
            TonyIommi.NumberOfFingers = 9;

            var RickAllen = new Human();
            RickAllen.FirstName = "Richard";
            RickAllen.LastName = "Allen";
            RickAllen.NumberOfFingers = 5;


             




            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page97a
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Program goal: To construct a list of three players from user input with two pieces of data each: name and shoe size.
            // EXCEPT the third will not have a shoe size and so will be given a default value. 

            Console.WriteLine("What is the first player's name?");
            string P1Name = Console.ReadLine();
            Console.WriteLine("What is the second player's name?");
            string P2Name = Console.ReadLine();
            Console.WriteLine("What is the third player's name?");
            string P3Name = Console.ReadLine();
            Console.WriteLine("What is, {0}, the first player's shoe size?", P1Name);
            string P1ShoeSize = Console.ReadLine();
            Console.WriteLine("What is, {0}, the first player's shoe size?", P2Name);
            string P2ShoeSize = Console.ReadLine();

            //Players crew = new Players();

            var crew1 = new Players(P1Name, P1ShoeSize);
            var crew2 = new Players(P2Name, P2ShoeSize);
            var crew3 = new Players(P3Name);

 
            


            Console.ReadLine();
        }
    }
}

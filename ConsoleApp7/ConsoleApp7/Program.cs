using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which name to print? 1, 2 or 3?");
            int whichName = Convert.ToInt32(Console.ReadLine());

            if (whichName == 1)
            {
              
                Console.WriteLine(nombreJoe());
            }
           else if (whichName == 2)
            {
                PrintMitch nombre = new PrintMitch();
                Console.WriteLine(nombre);
            }
            else if (whichName == 3)
            {
                PrintSesh nombre = new PrintSesh();
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }
    }
}

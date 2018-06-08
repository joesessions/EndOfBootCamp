using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many donuts do you have");
            int number = Convert.ToInt32(Console.ReadLine());
            bool v = number > 0;
            bool hasDonut = v;


            while (!hasDonut)
            {
                Console.WriteLine("C'mon, how many donuts?");
                number = Convert.ToInt32(Console.ReadLine());

                hasDonut = number > 0;
            }

            Console.WriteLine("I knew it!");
            Console.Read();
        }
    }
}
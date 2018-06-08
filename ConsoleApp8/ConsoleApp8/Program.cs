using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            if (userAnswer == 1)
            {
                MethodOne();
            }
            else if (userAnswer == 2)
            {
                MethodTwo();
            }
            else if (userAnswer == 3)
            {
                MethodThree();
            }

              

        }
        public static void MethodOne()
        {
            Class1 name = new Class1();
            name.number = 1;
            Console.WriteLine(name.number);
            Console.ReadLine();
        }
        public static void MethodTwo()
        {
            Class2 name = new Class2();
            name.number = 2;
            Console.WriteLine(name.number);
            Console.ReadLine();
        }
        public static void MethodThree()
        {
            Class3 name = new Class3();
            name.number = 3;
            Console.WriteLine(name.number);
            Console.ReadLine();
        }
    }
}

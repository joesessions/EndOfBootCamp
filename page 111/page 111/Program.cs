using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_111
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age? (Whole numbers only)");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0) { throw new NullReferenceException(); };

                int presentYear = DateTime.Now.Year;

                Console.WriteLine("Have you had your birthday yet this year? (y or n)");
                string bDayYet = Console.ReadLine();
                int birthYear = 2000;

                if (bDayYet == "y")
                {
                    birthYear = presentYear - age;
                }
                else
                {
                    birthYear = presentYear - age - 1;
                } 

                

                Console.WriteLine("You were born in "+ birthYear);
                Console.ReadLine();
           

            }
            catch (FormatException)
            {
                Console.WriteLine("Now, that wasn't a whole number, was it?");
                Console.ReadLine();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("If you were zero, you couldn't read this or type. Sorry.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("You or the program did something wrong, for sure.");
                Console.ReadLine();
            }


        }
    }
}

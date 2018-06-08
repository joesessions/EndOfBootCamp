using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page56
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the day of the week.");
                string input = Console.ReadLine();
                daysOfTheWeek today;
                Enum.TryParse(input, out today);
                Console.WriteLine(today);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Don't you know the days of the week? Try again. Start with a capital letter.");
            }
          

           
        }
        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

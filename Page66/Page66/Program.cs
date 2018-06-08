using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's the current date and time.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Give me a number, and I will tell you what time it will be that many hours from now.");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime nowTime = DateTime.Now;
            DateTime newTime = DateTime.Now; 
            newTime = nowTime.AddHours(hours);
            Console.WriteLine("In {0} hours, the time will be {1}", hours, newTime);
            Console.ReadLine();

        }
    }
}

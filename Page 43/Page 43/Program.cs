using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee timmy = new Employee { FirstName = "Sample" , LastName = "Student"};
            timmy.SayName();
            Console.ReadLine();

            IQuittable leaver = new Employee();
            leaver.Quit();

        }
    }
}

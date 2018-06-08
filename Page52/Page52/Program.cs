using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page52
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> JohnLeoSmith = new Employee<string>();
            Employee<Int32> SamRobertJames = new Employee<Int32>();

            JohnLeoSmith.FirstName = "John";
            JohnLeoSmith.LastName = "Smith";
            JohnLeoSmith.ID = 1;

            JohnLeoSmith.Things = new List<string> { "Car", "Bed", "Humidoor", "Frog cage", "Banana" };

            SamRobertJames.FirstName = "Sam";
            SamRobertJames.LastName = "James";
            SamRobertJames.ID = 1;

            SamRobertJames.Things = new List<int> { 34, 53, 67, 34, 65, 98, 45 };

            Console.WriteLine(JohnLeoSmith.FirstName + " " + JohnLeoSmith.LastName + " " + JohnLeoSmith.ID);
            //bool conflict = JohnLeoSmith == SamRobertJames;
            Console.ReadLine();



        }
    }
}

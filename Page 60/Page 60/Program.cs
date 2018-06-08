using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> payroll = new List<Employee>();

            Employee Frankie = new Employee();
            Frankie.FirstName = "Frank";
            Frankie.LastName = "Lewis";
            Frankie.ID = 1;
            payroll.Add(Frankie);

            Employee Julie = new Employee();
            Julie.FirstName = "Juliet";
            Julie.LastName = "Rancor";
            Julie.ID = 2;
            payroll.Add(Julie);

            Employee Joe = new Employee();
            Joe.FirstName = "Joe";
            Joe.LastName = "Korbin";
            Joe.ID = 3;
            payroll.Add(Joe);

            Employee Joey = new Employee();
            Joey.FirstName = "Joe";
            Joey.LastName = "Rancor";
            Joey.ID = 4;
            payroll.Add(Joey);

            Employee Todd = new Employee();
            Todd.FirstName = "Todd";
            Todd.LastName = "Toddamus";
            Todd.ID = 5;
            payroll.Add(Todd);

            Employee Joanna = new Employee();
            Joanna.FirstName = "Joanna";
            Joanna.LastName = "Smithereen";
            Joanna.ID = 6;
            payroll.Add(Joanna);

            Employee William = new Employee();
            William.FirstName = "William";
            William.LastName = "Teederhosen";
            William.ID = 7;
            payroll.Add(William);

            Employee Natty = new Employee();
            Natty.FirstName = "Natty";
            Natty.LastName = "Fatty";
            Natty.ID = 8;
            payroll.Add(Natty);

            Employee Devin = new Employee();
            Devin.FirstName = "Devonious";
            Devin.LastName = "Ricebalm";
            Devin.ID = 9;
            payroll.Add(Devin);

            Employee Lucy = new Employee();
            Lucy.FirstName = "Lucy";
            Lucy.LastName = "Stonewall";
            Lucy.ID = 10;
            payroll.Add(Lucy);

  
            List<Employee> Joes = payroll.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee J in Joes)
            {
                Console.WriteLine(J.LastName);
            }
     
            //foreach (Employee dude in payroll)
            //{

            //    if (dude.FirstName == "Joe")
            //    {
            //        Joes.Add(dude);
            //    }
            //    Console.WriteLine("Tried it.");
            //}
            Console.ReadLine();
        }
    }
}

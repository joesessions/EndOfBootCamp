using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_47
{
    public class Employee : Person, IQuittable
    {
        int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " "+ LastName);
        }
        public void Quit()
        {
            Console.WriteLine("You tell 'em I QUIT!!!");
            Console.ReadLine();
        }
        
        
        
    }
}

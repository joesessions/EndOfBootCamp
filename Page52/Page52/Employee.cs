using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page52
{
    public class Employee<T> 
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public List<T> Things { get; set; }

        //public static bool operator== (Employee emp1, Employee emp2)
        //{
        //    bool conflict=true;
        //    if (emp1.ID == emp2.ID)
        //    {
        //        Console.WriteLine("Major Data Corruption Issue Detected. Run for the hills.");
        //        conflict = true;
        //    }
        //    return conflict;
        //}

        //public static bool operator!= (Employee emp1, Employee emp2)
        //{
        //    bool conflict = false;
        //    if (emp1.ID != emp2.ID)
        //    {
        //        Console.WriteLine("These guys have unique ID numbers.");
        //        conflict = false;
        //    }
        //    return conflict;
        //}
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TwentyOne
//    {
//        public class Card
//        {
//            public Card()
//            {
//                Suit = "Spades";
//                Face = "Two";
//            }
//            public string Suit { get; set; }
//            public string Face { get; set; }
//        }
//    }

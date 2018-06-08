using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "I ";
            string second = "Love ";
            string third = "NY";
            string total = first + second + third;

            Console.WriteLine(total);
            Console.ReadKey();

            total = total.ToUpper();
            Console.WriteLine(total);
            Console.ReadKey();

            StringBuilder song = new StringBuilder();
            string one = "On the first day of Christmas, my true love gave to me, a partridge in a pear tree.";
            song.Append(one);
            Console.WriteLine(song);
            Console.ReadKey();

            string two = "On the second day of Christmas, my true love gave to me, two turtle doves.";
            song.Append(two);
            Console.WriteLine(song);
            Console.ReadKey();

            string three = "On the third day of Christmas, my true love gave to me, three French hens.";
            song.Append(three);
            Console.WriteLine(song);
            Console.ReadKey();

            string four = "On the fourth day of Christmas, my true love gave to me, four calling birds.";
            song.Append(four);
            Console.WriteLine(song);
            Console.ReadKey();

        }
    }
}

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Page35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give an integer, and we will see the difference between adding, multiplying and division.");
            int userInt = Convert.ToInt32(Console.ReadLine());

            ThreeOps output = new ThreeOps();

            int outSum;
            int outProd;
            int outDiv;

            outSum = output.AddThree(userInt);
            outProd = output.MultThree(userInt);
            outDiv = output.DivThree(userInt);

            Console.WriteLine("Here is the sum: " + userInt + " + 3 = " +
                outSum);
            Console.WriteLine("Here is the product: " + userInt + " x 3 = " +
                outProd);
            Console.WriteLine("Here is the exponent: " + userInt + " / 3 = " +
                outDiv);
            Console.ReadLine();
        }
    }
}

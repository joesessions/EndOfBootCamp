using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_97
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreMathDoers = true;

            List<MathDoers> Dudes = new List<MathDoers>();


            while (moreMathDoers == true)
            {
                Console.WriteLine("Are there more math doers to add? (y or n)");
                string more = Console.ReadLine();

                if (more != "n")
                {
                    MathDoers guy = new MathDoers();

                    Console.WriteLine("What is their name?");
                    guy.Name = Console.ReadLine();
                    Console.WriteLine("What is their age?");
                    guy.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is their shoeSize?");
                    guy.ShoeSize = Convert.ToInt32(Console.ReadLine());
                    Dudes.Add(guy);
                    
                }
                else { moreMathDoers = false; }
            }
            Console.WriteLine("Stopping here.");
            Console.ReadLine();



            //Console.WriteLine("John is {0} years old and has a shoe size of {1}", John.Age, John.ShoeSize);

            //Console.WriteLine("Welcome to the erroneous calculator! See if you can deduce the error I make!");

            //Console.WriteLine("Give me the first number");
            //int operandOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Give me the second number");
            //int operandTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type 1 for addition, 2 for subtraction");
            //int opNumber = Convert.ToInt32(Console.ReadLine());

            //var calc = new MathFact();

            //var answer = calc.mathFact(operandOne, operandTwo, opNumber);

            //const int error = 3;
        

            //Console.WriteLine("The answer is " + (answer+error));
            //Console.ReadLine();


            //Player player = new Player(playerName, bank);
        }
    }
}

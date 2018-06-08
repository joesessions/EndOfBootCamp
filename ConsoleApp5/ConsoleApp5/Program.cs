using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //        1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

       try
        {
            List<int> numerators = new List<int>() { 34, 24, 10, 52, 100, 8, 70 };
            Console.WriteLine("I have a list of numbers: 34, 24, 10, 52, 100, 8, 70. Give me a number to divide them by.");
            int denominator = Convert.ToInt32(Console.ReadLine());

            foreach (int numerator in numerators)
            {
                int quotient = numerator / denominator;
                Console.WriteLine(numerator + " divided by " + denominator + " equals " + quotient);

            }
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }

        //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.



        //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.


        //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.


        //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by" + " equals " + numberThree);
        //    Console.ReadKey();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("And that's all we're gonna do.");
        //    Console.ReadKey();
        //}
        //Console.ReadKey();

    }
}

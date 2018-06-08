using System;
using System.Collections.Generic;

class Program
    {
    static void Main()
    {
        try
        {
            Console.WriteLine("Give one of these numbers: 0, 1, 2, 3.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            string[] nameList = { "Steeve", "Sally", "Johniper", "Jody" };

            Console.WriteLine(nameList[userChoice]);
            Console.ReadLine();

            Console.WriteLine("Give one of these numbers: 0, 1, 2, 3.");
            userChoice = Convert.ToInt32(Console.ReadLine());
            int[] intList = { 23, 4329857, 1, 7 };

            Console.WriteLine(intList[userChoice]);
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("Toys");
            stringList.Add("Money");
            stringList.Add("Movies");
            stringList.Add("Fish");
            stringList.Add("Rocks");
            stringList.Add("The Holy Hand Grenada");

            Console.WriteLine("Give one of these numbers: 0, 1, 2, 3, 4, 5.");
            int userChoice3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[userChoice3]);
            Console.ReadLine(); 
        }
        catch (Exception) 
        {
            Console.WriteLine("That wasn't one of the options.");
            Console.ReadKey();
            //code specifically for a ArgumentNullException
        }

      

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[3] = 650;

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();

        //List<int> intList = new List<int>();
        //intList.Add(4 );
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadKey();


    }
}


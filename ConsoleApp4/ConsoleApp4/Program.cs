using System;
using System.Collections.Generic;

namespace Page29
{
    class Program
    {
        static void Main(string[] args)
        {


            //            1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that
            //   goes through each string in the Array, adding the user’s text to the string.Then create a loop
            //  that prints off each string in the Array on a separate line.

            string[] favCars = new string[6];

            for (int i = 0; i < favCars.Length; i++)
            {
                Console.WriteLine("Enter one of your favorite cars.");
                favCars[i] = Console.ReadLine();
            }

            Console.WriteLine("Here's that list:");

            for (int j = 0; j < favCars.Length; j++)
            {
                Console.WriteLine(favCars[j]);
            }
            Console.ReadLine();


            //2.Create an infinite loop.

            //Console.WriteLine("Press any key to enter the neverending counter.");

            //for (int i = 1; i > 0; i++)
            //{
            //    if (i % 10000 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("This line will never print.");

            //3.Fix the infinite loop so it will execute.

            Console.WriteLine("Press any key to have the computer count to 100 million.");

            for (int i = 1; i < 100000000; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("This line will print.");
            Console.ReadLine();

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //Covered by #1

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            Console.WriteLine("WORTHLESS BLACKJACK SIM");
            Console.WriteLine("Aces are always 1. There is no dealer to play against. You have to hit until you bust.");
            Console.ReadKey();
            Console.WriteLine("Press any key to take a card.");
            Console.ReadKey();
            Random rnd = new Random();
            int card = rnd.Next(1, 14);
            if (card > 10) { card = 10; }

            int hand = card;
            Console.WriteLine("You have " + hand + " total.");

            for (int i = 0; hand <= 20; i++)
            {
                Console.WriteLine("Press any key to take another card. Resistance is futile.");
                Console.ReadKey();
                card = rnd.Next(1, 14);
                if (card > 10) { card = 10; }

                hand = hand + card;
                Console.WriteLine("You have " + hand + " total.");
            }
            Console.WriteLine("You went bust.");
            Console.ReadKey();

            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to
            //   search for in the List.Create a loop that iterates through the loop and then    displays the
            //   index of the array that contains matching text on the screen.

            //  PLUS:

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> assignments = new List<string>();

            assignments.Add("1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.");
            assignments.Add("2. Create an infinite loop.");
            assignments.Add("3. Fix the infinite loop so it will execute.");
            assignments.Add("4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.");
            assignments.Add("5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.");
            assignments.Add("6. Create a List of strings where each item in the list is unique. Ask the user to select text to  search for in the List. Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.");
            assignments.Add("7. Add code to that above loop that tells a user if they put in text that isn’t in the List.");
            assignments.Add("8. Add code to that above loop that stops it from executing once a match has been found.");
            assignments.Add("9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. Create a loop that iterates through the    loop and then displays the indices of the array that contain matching text on the screen.");
            assignments.Add("10. Add code to that above loop that tells a user if they put in text that isn’t in the List.");
            assignments.Add("11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the    string and whether or not it has already appeared in the list.");

            Console.WriteLine("Enter some text to be searched for in the list of assignments.");
            string search = Console.ReadLine();
            bool foundAnything = false;


            for (int assignment = 0; assignment < assignments.Count; assignment++)
            {
                if (assignments[assignment].Contains(search))
                {
                    Console.WriteLine("This assignment contains that text:");
                    Console.WriteLine(assignment + 1);
                    foundAnything = true;
                }
            }
            if (!foundAnything)
            {
                Console.WriteLine("Nothing matched your search.");
            }
            Console.ReadLine();

            Console.ReadLine();


            //8.Add code to that above loop that stops it from executing once a match has been found.


            Console.WriteLine("Enter some text to be searched for in the list of assignments.");
            search = Console.ReadLine();
            foundAnything = false;


            for (int assignment = 0; assignment < assignments.Count; assignment++)
            {
                if (assignments[assignment].Contains(search) && !foundAnything)
                {
                    Console.WriteLine("This assignment contains that text:");
                    Console.WriteLine(assignment + 1);
                    Console.WriteLine("There might be others, but we stopped there.");
                    foundAnything = true;
                }
            }
            if (!foundAnything)
            {
                Console.WriteLine("Nothing matched your search.");
            }
            Console.ReadLine();

            Console.ReadLine();

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the    loop and then displays the indices of the array that contain matching text on the screen.
            // PLUS
            //10..Add code to that above loop that tells a user if they put in text that isn’t in the List.

            assignments.Add("2. Create an infinite loop.");

            Console.WriteLine("Enter some text to be searched for in the list of assignments.");
            search = Console.ReadLine();
            foundAnything = false;


            for (int assignment = 0; assignment < assignments.Count; assignment++)
            {
                if (assignments[assignment].Contains(search))
                {
                    Console.WriteLine("This assignment contains that text:");
                    Console.WriteLine(assignment + 1);
                    foundAnything = true;
                }
            }
            if (!foundAnything)
            {
                Console.WriteLine("Nothing matched your search.");
            }
            Console.ReadLine();

            Console.ReadLine();


            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the    string and whether or not it has already appeared in the list.

             assignments.Add("9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. Create a loop that iterates through the    loop and then displays the indices of the array that contain matching text on the screen.");


            Console.WriteLine("Hit Enter to search for duplicate lines.");
            search = Console.ReadLine();
            foundAnything = false;


            for (int assignment = 0; assignment < assignments.Count; assignment++)
            {
                for (int assigncomp = assignment +1 ; assigncomp < assignments.Count; assigncomp++)
                {

                    if (assignments[assignment] == assignments[assigncomp])
                    {
                        Console.WriteLine("These two lines are identical:");
                        Console.WriteLine(assignment + 1);
                        Console.WriteLine(assigncomp + 1);
                        foundAnything = true;
                    }
                }
            }
            if (!foundAnything)
            {
                Console.WriteLine("Nothing matched your search.");
            }
            Console.ReadLine();

            Console.ReadLine();



        }
    }
}

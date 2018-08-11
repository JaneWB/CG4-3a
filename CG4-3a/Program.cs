using System;

namespace CG4_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user to enter up to 30 names.If the user hits enter without 
            //entering a name, assume they are done and stop asking them.  Then you will randomly choose
            //a name from the array and write it to the console as the winner.We haven't learned how to 
            //randomize yet, so you'll need to stretch your Googling skills.Then you will write the list 
            //of other names that did not win.  Upload your program to a new repository called CG 4 - 3.
            //Upload a link to your repository here when you are finished.

            //Ask fo user input.
            Console.WriteLine("Enter up to 30 names");

            //Create an array with 30 items.
            string[] names = new string[30];

            //this is to keep a count of how many names are entered, var must be assigned when used
            int namesEntered;

            //this is the loop, this is usually an i or j
            for (namesEntered = 0; namesEntered < 30; namesEntered++)
            {
                //loops through 0 to 29
                names[namesEntered] = Console.ReadLine();

                //if enter is pressed without typing name, loop stops/breaks.  This references a specific part of the array.
                if (names[namesEntered] == "")
                {
                    break;
                }
                //Goes through each name adding the next name each time.
                //namesEntered++;

            }
            //Assign variable for randomizer.  Can use var or int.
            var randomizer = new Random();

            //Creates a random choice from names.
            var winner = randomizer.Next(0, namesEntered);

            //Console.WriteLine("The winner is  " + names[winner]);

            //or

            //Prints to console the winner. $ means I am putting variables in the string.
            //names is from the array and winner is from the randomizer.
            Console.WriteLine($"The winner is {names[winner]}!");

            //Names References the entire array and each iteration of the loop puts one element from names into name. 
            foreach (string name in names)
            {
                //If entered is pressed without typing a name the loop stops/breaks.
                if (name == "")
                {
                    break;
                }

                //
                if (names[winner] == name)
                {
                    continue;
                }

                Console.WriteLine($"{name} lost.");
            }
            //Stops program and doesn't close until entered is pressed.  Provides the ability to read the console.
            Console.ReadLine();
        }
    }
}


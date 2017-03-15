using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // pick a random number between 1 and 100
            Random rng = new Random();
            int target = rng.Next(100) + 1;

            // keep asking the user until they guess correctly
            while (!Ask(target))
            {
                Console.WriteLine("Incorrect.");
            }

            // correct
            Console.WriteLine("Correct!");

            // terminate after key press
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static bool Ask(int target)
        {
            // ask the user for a number
            Console.WriteLine("Guess the number (between 1 and 100):");
            string input = Console.ReadLine();

            // parse input
            if (int.TryParse(input, out int inputValue))
            {
                return inputValue == target;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return false;
            }
        }
    }
}

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
            
            // ask the user to guess the number
            if (Ask(target))
            {
                // correct
                Console.WriteLine("Correct!");
            }
            else
            {
                // incorrect
                Console.WriteLine(
                    $"Incorrect. The correct answer was {target}.");
            }

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

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
            Result result = Ask(target);
            while (result != Result.Correct)
            {
                // display relevant message
                switch (result)
                {
                    case Result.TooLow:
                        Console.WriteLine("Incorrect (too low).");
                        break;
                    case Result.TooHigh:
                        Console.WriteLine("Incorrect (too high).");
                        break;
                    case Result.InvalidInput:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                // ask again
                result = Ask(target);
            }

            // correct
            Console.WriteLine("Correct!");

            // terminate after key press
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static Result Ask(int target)
        {
            // ask the user for a number
            Console.WriteLine("Guess the number (between 1 and 100):");
            string input = Console.ReadLine();

            // parse input
            if (!int.TryParse(input, out int inputValue))
                return Result.InvalidInput;

            // was the user correct?
            if (inputValue == target)
                return Result.Correct;

            // if not, describe why not
            return inputValue > target
                ? Result.TooHigh
                : Result.TooLow;
        }
    }

    enum Result
    {
        Correct,
        TooLow,
        TooHigh,
        InvalidInput,
    }
}

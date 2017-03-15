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

            // print target number
            Console.WriteLine(target);
            Console.ReadKey();
        }
    }
}

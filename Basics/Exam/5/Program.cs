using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int foodInGr = foodInKg * 1000;

            while (input != "Adopted")
            {
                int foodConsumed = int.Parse(input);
                foodInGr -= foodConsumed;
                input = Console.ReadLine();
            }
            if (foodInGr >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGr} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGr)} grams more.");
            }

        }
    }
}
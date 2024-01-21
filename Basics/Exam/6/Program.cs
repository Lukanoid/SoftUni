using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLocations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLocations; i++)
            {
                double expectedGold = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double totalgold = 0;

                for (int j = 0; j < days; j++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    totalgold += goldPerDay;
                }
                double averageGold = totalgold / days;
                if (averageGold >= expectedGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                }
                else
                {
                    double diff = expectedGold - averageGold;
                    Console.WriteLine($"You need {diff:f2} gold.");
                }
            }
        }
    }
}
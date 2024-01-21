using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double priceForBoat = 0;

            if (season == "Spring")
            {
                priceForBoat = 3000;
            }
            else if (season == "Summer" ||  season == "Autumn")
            {
                priceForBoat = 4200;
            }
            else
            {
                priceForBoat = 2600;
            }
            if (fishermen <= 6)
            {
                priceForBoat *= 0.9;
            }
            else if (fishermen > 7 && fishermen < 12)
            {
                priceForBoat *= 0.85;
            }
            else
            {
                priceForBoat *= 0.75;
            }
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                priceForBoat *= 0.95;
            } 
            if (budget >= priceForBoat)
            {
                double moneyleft = budget - priceForBoat;
                Console.WriteLine($"Yes! You have {moneyleft:f2} leva left.");
            }
            else
            {
                double diff = Math.Abs(budget - priceForBoat);
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}
using System;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double totalPriceForBeer = beers * 1.2;
            double priceForChips = totalPriceForBeer * 0.45;
            double totalPriceForChips = Math.Ceiling(chips * priceForChips);
            double totalPrice = totalPriceForBeer + totalPriceForChips;

            if (budget >= totalPrice)
            {
                double diff = Math.Abs(budget - totalPrice);
                Console.WriteLine($"{name} bought a snack and has {diff:f2} leva left. ");
            }
            else
            {
                Console.WriteLine($"{name} needs {totalPrice - budget:f2} more leva!");
            }
        }
    }
}
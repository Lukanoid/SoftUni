using System;

namespace FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolais = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());

            double priceForMagnolais = magnolais * 3.25;
            double priceForHyacinths = hyacinths * 4;
            double priceForRoses = roses * 3.5;
            double priceForCacti = cacti * 8;

            double sum = priceForMagnolais + priceForHyacinths + priceForRoses + priceForCacti;
            double tax = sum * 0.05;
            double moneyLeft = sum - tax;

            if (moneyLeft >= priceForGift)
            {
                double diff = Math.Floor(moneyLeft - priceForGift);
                Console.WriteLine($"She is left with {diff} leva.");
            }
            else
            {
                double diff = Math.Ceiling(priceForGift - moneyLeft);
                Console.WriteLine($"She will have to borrow {diff} leva.");
            }
            
        }
    }
}
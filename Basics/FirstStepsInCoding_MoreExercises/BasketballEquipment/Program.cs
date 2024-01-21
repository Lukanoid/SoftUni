using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualPrice = int.Parse(Console.ReadLine());

            double priceForShoes = annualPrice * 0.6;
            double priceForEquipment = priceForShoes * 0.8;
            double priceForBall = priceForEquipment * 0.25;
            double priceForAccessories = priceForBall * 0.2;

            double finalsum = annualPrice + priceForShoes + priceForEquipment + priceForAccessories + priceForBall;

            Console.WriteLine(finalsum);
        }
    }
}
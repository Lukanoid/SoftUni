using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggie  = int.Parse(Console.ReadLine());

            double priceForChicken = chicken * 10.35;
            double priceForFish = fish * 12.4;
            double priceForVeggie = veggie * 8.15;
            double sumWithouDessert = priceForChicken + priceForFish + priceForVeggie;
            double dessert = sumWithouDessert * 0.2;

            double finalsum = sumWithouDessert + dessert + 2.5;

            Console.WriteLine(finalsum);

        }
    }
}
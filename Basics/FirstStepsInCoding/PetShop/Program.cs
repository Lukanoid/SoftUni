using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogfood = int.Parse(Console.ReadLine());
            int catfood = int.Parse(Console.ReadLine());

            double dogfoodprice = dogfood * 2.5;
            double catfoodprice = catfood * 4;

            double finalsum = dogfoodprice + catfoodprice;

            Console.WriteLine($"{finalsum} lv.");
        }
    }
}
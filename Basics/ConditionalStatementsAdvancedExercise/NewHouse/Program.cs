using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Roses")
            {
                price = number * 5;
                if (number > 80)
                {
                    price *= 0.9;
                }
            }
            else if (type == "Dahlias")
            {
                price = number * 3.8;
                if (number > 90)
                {
                    price *= 0.85;
                }
            }
            else if (type == "Tulips")
            {
                price = number * 2.8;
                if (number > 80)
                {
                    price *= 0.85;
                }
            }
            else if (type == "Narcissus")
            {
                price = number * 3;
                if (number < 120)
                {
                    price = price + (price * 0.15);
                }
            }
            else
            {
                price = number * 2.5;
                if (number < 80)
                {
                    price = price + (price * 0.2);
                }
            }
            if (price <= budget)
            {
                double moneyleft = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {number} {type} and {(moneyleft):f2} leva left.");
            }
            else
            {
                double diff = price - budget;
                Console.WriteLine($"Not enough money, you need {diff:f2} leva more.");
            }
        }
    }
}
using System;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double clothesperworker = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double priceforclothes = workers * clothesperworker;
            
            if (workers > 150)
            {
                priceforclothes = priceforclothes * 0.9;
            }

            double totalsum = decor + priceforclothes;

            if (budget >= totalsum)
            {
                double diff = budget - totalsum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
            }
            else
            {
                double diff = budget - totalsum;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(diff):f2} leva more.");
            }
        }
    }
}
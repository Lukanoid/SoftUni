using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int litterswinerequired = int.Parse(Console.ReadLine());
            int workes = int.Parse(Console.ReadLine());

            double totalgrape = vineyard * grape;
            double wine = totalgrape * 0.4 / 2.5;

            if (wine >= litterswinerequired)
            {
                double littersleft = wine - litterswinerequired;
                double litterperworker = littersleft / workes;

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{littersleft} liters lift -> {litterperworker} liters per person.");
            }
            else
            {

            }
        }
    }
}
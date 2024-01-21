using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int tinner = int.Parse(Console.ReadLine());
            int hoursRequired = int.Parse(Console.ReadLine());
            double bags = 0.4;

            double priceForNylon = (nylon + 2) * 1.5;
            double priceForPaint = (paint + (paint * 0.1)) * 14.50;
            double priceForTinner = tinner * 5;

            double priceWithoutWork = priceForNylon + priceForPaint + priceForTinner + bags;
            double priceForWorkers = (priceWithoutWork * 0.30) * hoursRequired;

            double finalsum = priceWithoutWork + priceForWorkers;

            Console.WriteLine(finalsum);

        }
    }
}
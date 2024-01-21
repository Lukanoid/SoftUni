using System;
using System.ComponentModel;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"{sum / n:f2}");
        }
    }
}
using System;
using System.Numerics;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum = sum + numbers; 
            }
            Console.WriteLine(sum);

        }
    }
}
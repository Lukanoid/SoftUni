using System;
using System.Security.Cryptography;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

                int sumLeft = 0;

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sumLeft += newNumber;
            }

            int sumRight = 0;

            for(int i = 0;i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sumRight += newNumber;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                int diff = Math.Abs(sumLeft - sumRight);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
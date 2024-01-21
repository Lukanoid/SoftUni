using System;
using System.Security.Cryptography;

namespace HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                totalSum += newNumber;

                if (newNumber > maxNumber)
                {
                    maxNumber = newNumber;
                }
            }
            int sumWithoutMaxNumber = totalSum - maxNumber;

            if (sumWithoutMaxNumber == maxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(sumWithoutMaxNumber - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }

        }
    }
}
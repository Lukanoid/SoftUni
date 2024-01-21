using System;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while (true)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;

                if (sum >= n)
                {
                    Console.WriteLine(sum);
                    break;
                }

            }
        }
    }
}
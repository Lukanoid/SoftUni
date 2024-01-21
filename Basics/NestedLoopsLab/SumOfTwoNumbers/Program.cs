using System;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            bool flag = false;

            for (int i = start; i <= end; i++)
            {
                if (flag)
                {
                    break;
                }
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (i + j == n)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {i + j})");
                        flag = true;
                        break;
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{count} combinations - neither equals {n}");
            }
        }
    }
}
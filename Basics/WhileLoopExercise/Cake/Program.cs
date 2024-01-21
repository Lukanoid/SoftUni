using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int cakeSize = n1 * n2;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                cakeSize -= pieces;
                if (cakeSize < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
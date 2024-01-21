using System;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double increase = double.Parse(input);

                if (increase <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;                   
                }

                sum += increase;
                Console.WriteLine($"Increase: {increase:f2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = -1; // използваме -1, защото при деление на 0 няма да има решение, но в случая ще работи и на 0
            if (num % 10 == 0)
            {
                number = 10;
            }
            else if (num % 7 == 0)
            {
                number = 7;
            }
            else if (num % 6 == 0)
            {
                number = 6;
            }
            else if (num % 3 == 0)
            {
                number = 3;
            }
            else if (num % 2 == 0)
            {
                number = 2;
            }

            if (number == -1)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
        }
    }
}
     
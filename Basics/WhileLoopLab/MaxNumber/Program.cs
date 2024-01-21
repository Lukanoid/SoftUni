using System;

namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int newInput = int.Parse(input);

                if (newInput > maxNumber)
                {
                    maxNumber = newInput;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
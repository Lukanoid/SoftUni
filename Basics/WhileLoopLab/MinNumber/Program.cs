using System;
using System.Security.Cryptography.X509Certificates;

namespace MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int newInput = int.Parse(input);

                if (newInput < minNumber)
                {
                    minNumber = newInput;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
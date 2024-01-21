using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int freeSpace = n1 * n2 * h;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxSize = int.Parse(input);
                freeSpace -= boxSize;
                if (freeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
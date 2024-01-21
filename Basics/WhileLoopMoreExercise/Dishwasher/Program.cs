using System;

namespace Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 1;
            int detergent = bottles * 750;
            int pots = 0;
            int dishes = 0;

            while (input != "End")
            {
                int plates = int.Parse(input);
                if (count == 3)
                {
                    int detergendUsed = plates * 15;
                    detergent -= detergendUsed;
                    count = 1;
                    pots += plates;
                }
                else
                {
                    int detergentUsed = plates * 5;
                    detergent -= detergentUsed;
                    dishes += plates;
                    count++;
                }
                if(detergent < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (detergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
            }
        }
    }
}
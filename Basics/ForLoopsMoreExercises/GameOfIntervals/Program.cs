using System;

namespace GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            double result = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;
            int x5 = 0;
            int x6 = 0;


            for (int i = 0; i < entries; i++)
            {
                int turn = int.Parse(Console.ReadLine());

                if (turn < 0 || turn > 50)
                {
                    result = result / 2;
                    x1++;
                }
                else if (turn < 10)
                {
                    result += turn * 0.2;
                    x2++;
                }
                else if (turn < 20)
                {
                    result += turn * 0.3;
                    x3++;
                }
                else if (turn < 30)
                {
                    result += turn * 0.4;
                    x4++;
                }
                else if (turn < 40)
                {
                    result += 50;
                    x5++;
                }
                else
                {
                    result += 100;
                    x6++;
                }
            }
            double x1Average = (double)x1 / entries * 100;
            double x2Average = (double)x2 / entries * 100;
            double x3Average = (double)x3 / entries * 100;
            double x4Average = (double)x4 / entries * 100;
            double x5Average = (double)x5 / entries * 100;
            double x6Average = (double)x6 / entries * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {x2Average:f2}%");
            Console.WriteLine($"From 10 to 19: {x3Average:f2}%");
            Console.WriteLine($"From 20 to 29: {x4Average:f2}%");
            Console.WriteLine($"From 30 to 39: {x5Average:f2}%");
            Console.WriteLine($"From 40 to 50: {x6Average:f2}%");
            Console.WriteLine($"Invalid numbers: {x1Average:f2}%");
        }
    }
}
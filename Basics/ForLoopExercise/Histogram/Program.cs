using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;



            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1 = p1 + 1;
                }
                else if (number < 400)
                {
                    p2 = p2 + 1;
                }
                else if (number < 600)
                {
                    p3 = p3 + 1;
                }
                else if (number < 800)
                {
                    p4 = p4 + 1;
                }
                else
                {
                    p5 = p5 + 1;
                }

            }
            double p1Percent = p1 / n * 100;
            double p2Percent = p2 / n * 100;
            double p3Percent = p3 / n * 100;
            double p4Percent = p4 / n * 100;
            double p5Percent = p5 / n * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }
    }
}
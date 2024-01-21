using System;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double peopleCount = 0;
            double peak1 = 0;
            double peak2 = 0;
            double peak3 = 0;
            double peak4 = 0;
            double peak5 = 0;

            for (int i = 0; i < n; i++)
            {
                int group = int.Parse(Console.ReadLine());
                peopleCount += group;

                if (group <= 5)
                {
                    peak1 += group;
                }
                else if (group <= 12)
                {
                    peak2 += group;
                }
                else if (group <= 25)
                {
                    peak3 += group;
                }
                else if (group <= 40)
                {
                    peak4 += group;
                }
                else
                {
                    peak5 += group;
                }
            }

            peak1 = peak1 / peopleCount * 100;
            peak2 = peak2 / peopleCount * 100;
            peak3 = peak3 / peopleCount * 100;
            peak4 = peak4 / peopleCount * 100;
            peak5 = peak5 / peopleCount * 100;

            Console.WriteLine($"{peak1:f2}%");
            Console.WriteLine($"{peak2:f2}%");
            Console.WriteLine($"{peak3:f2}%");
            Console.WriteLine($"{peak4:f2}%");
            Console.WriteLine($"{peak5:f2}%");
        }
    }
}
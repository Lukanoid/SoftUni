using System;

namespace BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int manYears = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    inheritance -= 12000;
                }
                else
                {
                    inheritance -= 12000 + (manYears * 50);
                }
                manYears++;
            }
            if (inheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritance):f2} dollars to survive.");
            }
        }
    }
}
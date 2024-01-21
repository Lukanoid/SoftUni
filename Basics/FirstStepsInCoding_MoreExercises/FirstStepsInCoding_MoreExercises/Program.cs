using System;
using System.Globalization;

namespace FirstStepsInCoding_MoreExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * 1.79549;

            Console.WriteLine(bgn);
        }
    }
}
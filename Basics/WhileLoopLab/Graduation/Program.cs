using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            int count = 0;
            double sum = 0;

            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                year++;
                if (grade < 4.00)
                {
                    count++;
                }
                if (count > 1)
                {
                    break;
                }
                sum += grade;
            }
            if (count > 1)
            {
                Console.WriteLine($"{name} has been excluded at {year - 2} grade");
            }
            else
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
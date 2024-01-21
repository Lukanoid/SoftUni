using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double allGrades = 0;
            int fail = 0;
            int c = 0;
            int b = 0;
            int topStudents = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                allGrades += grade;

                if (grade < 3)
                {
                    fail++;
                }
                else if (grade <= 3.99)
                {
                    c++;
                }
                else if (grade <= 4.99)
                {
                    b++;
                }
                else
                {
                    topStudents++;
                }
            }
            double average = (double)allGrades / numberOfStudents;
            double averageFails = (double)fail / numberOfStudents;
            double averageC = (double)c / numberOfStudents;
            double averageB = (double)b / numberOfStudents;
            double averageTopStudents = (double)topStudents / numberOfStudents;

            Console.WriteLine($"Top students: {averageTopStudents * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {averageB * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageC * 100:f2}%");
            Console.WriteLine($"Fail: {averageFails * 100:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
using System;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            string problemName = string.Empty;
            int poorGradesCount = 0;
            int sum = 0;
            int problemsSolved = 0;
            string lastProblem = string.Empty;

            while (true)
            {
                problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    double average = (double)sum / problemsSolved;
                    Console.WriteLine($"Average score: {average:f2}");
                    Console.WriteLine($"Number of problems: {problemsSolved}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                sum += grade;

                if (grade <= 4)
                {
                    poorGradesCount++;
                    if (poorGradesCount == poorGrades)
                    {
                        Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                        break;
                    }
                }
                lastProblem = problemName;
                problemsSolved++;
            }

        }
    }
}
using System.Runtime.InteropServices.ComTypes;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] data = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = data[0];
                string name = data[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(name);
                }
                else
                {
                    courses[courseName].Add(name);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.Write($"-- {student}");
                    Console.WriteLine();
                }
            }
        }
    }
}
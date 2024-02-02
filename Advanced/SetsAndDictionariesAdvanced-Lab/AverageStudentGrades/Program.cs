
namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> studentsRecord = new Dictionary<string,List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] currentStudent = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = currentStudent[0];
                decimal value = decimal.Parse(currentStudent[1]);

                if (studentsRecord.ContainsKey(name))
                {
                    studentsRecord[name].Add(value);
                }
                else
                {
                    studentsRecord.Add(name, new List<decimal> { value });
                }
            }

            foreach (var student in studentsRecord)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                decimal average = student.Value.Average();
                Console.Write($"(avg: {average:F2})");
                Console.WriteLine();
            }
        }
    }
}

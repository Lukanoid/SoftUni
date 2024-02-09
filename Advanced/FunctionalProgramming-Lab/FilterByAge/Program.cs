using System.Threading.Channels;

namespace FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] human = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = human[0];
                int age = int.Parse(human[1]);

                Student student = new Student() { Name = name, Age = age };

                students.Add(student);
            }

            string filterType = Console.ReadLine();
            int filterNumber = int.Parse(Console.ReadLine());
            Func<Student, int, bool> filter = FilterGenerator(filterType);

            students = students.Where(student => filter(student, filterNumber))
                .ToList();

            string format = Console.ReadLine();

            Action<Student> printer = PrinterGenerator(format);

            students.ForEach(student => printer(student));
        }

        private static Action<Student> PrinterGenerator(string format)
        {
            if (format == "name age")
            {
                return s=> Console.WriteLine($"{s.Name} - {s.Age}");
            }

            if (format == "name")
            {
                return s => Console.WriteLine($"{s.Name}");
            }

            if (format == "age")
            {
                return s => Console.WriteLine($"{s.Age}");
            }

            return null;
        }

        private static Func<Student, int, bool> FilterGenerator(string filterType)
        {
            Func<Student, int, bool> filter = null;
            if (filterType == "older")
            {
                filter = (student, number) => student.Age >= number;
            }
            if (filterType == "younger")
            {
                filter = (student,number) => student.Age < number;
            }

            return filter;
        }

        public class Student
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}

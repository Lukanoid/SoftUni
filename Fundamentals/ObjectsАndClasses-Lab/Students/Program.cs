namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> allStudents = new List<Student>();
            
            while (input != "end")
            {
                string[] studentsInformation = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentsInformation[0];
                string lastName = studentsInformation[1];
                string age = studentsInformation[2];
                string homeTown = studentsInformation[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                allStudents.Add(student);

                input = Console.ReadLine();
            }

            string searchedTown = Console.ReadLine();

            foreach (var student in allStudents)
            {
                if (student.HomeTown == searchedTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Age { get; set; }

            public string HomeTown { get; set; }
        }
    }
}
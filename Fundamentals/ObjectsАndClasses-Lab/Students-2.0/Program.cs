using System.Runtime.InteropServices.ComTypes;

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

                if (IsStudentAlreadyExisting(allStudents, firstName, lastName))
                {
                    Student student = GetStudent(allStudents, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;


                    allStudents.Add(student);
                }

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

        static bool IsStudentAlreadyExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
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
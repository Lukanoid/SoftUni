namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            University university = new University(students);

            foreach (var student in university)
            {
                Console.WriteLine(student);
            }
        }
    }
}

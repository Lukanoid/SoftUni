namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }


            List<Person> sorted = people.Where(p => p.Age > 30).OrderBy(x=>x.Name).ToList();

            foreach (var human in sorted) 
            {
                Console.WriteLine($"{human.Name} - {human.Age}");
            }
        }
    }
}

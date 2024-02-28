namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Person> persons = new List<Person>();

            while ((command = Console.ReadLine()) != "END")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = data[0],
                    Age = int.Parse(data[1]),
                    Town = data[2]
                };

                persons.Add(person);

            }

            int indexToCompare = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = persons[indexToCompare];

            int equalPeople = 0;
            int diffPeople = 0;

            foreach (var person in persons)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    diffPeople++;
                }
            }

            if (equalPeople == 1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {diffPeople} {persons.Count}");
            }
        }
    }
}

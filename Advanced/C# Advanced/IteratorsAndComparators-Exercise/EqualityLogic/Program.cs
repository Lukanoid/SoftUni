namespace EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            HashSet<Person> hashPeople = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person currentPerson = new Person()
                {
                    Name = personData[0],
                    Age = int.Parse(personData[1])
                };

                hashPeople.Add(currentPerson);
                sortedPeople.Add(currentPerson);
            }

            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}

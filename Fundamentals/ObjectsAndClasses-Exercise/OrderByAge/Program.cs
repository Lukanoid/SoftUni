using System.Linq;

List<Person> persons = new List<Person>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string name = command[0];
    string id = command[1];
    int age = int.Parse(command[2]);

    Person currentPerson = new Person(name, id, age);

    persons.Add(currentPerson);
    if (persons.Select(x => x.Id).Contains(id))
    {
        currentPerson.Name = name;
        currentPerson.Age = age;
    }

    input = Console.ReadLine();
}

foreach (var person in persons.OrderBy(x => x.Age))
{
    Console.WriteLine(person);
}


public class Person
{
    public Person(string name, string id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }

    public string Name { get; set; }
    public string Id { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";

    }
}
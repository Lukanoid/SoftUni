using System.Text;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "Enroll")
                {
                    string heroName = data[1];
                    if (!heroes.ContainsKey(heroName))
                    {
                        heroes.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (data[0] == "Learn")
                {
                    string heroName = data[1];
                    string spellName = data[2];
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (heroes[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}");
                    }
                    else
                    {
                        heroes[heroName].Add(spellName);
                    }
                }
                else
                {
                    string heroName = data[1];
                    string spellName = data[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (!heroes[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}");
                    }
                    else
                    {
                        heroes[heroName].Remove(spellName);
                    }
                }
            }

            Console.WriteLine($"Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
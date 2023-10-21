using System.Net.Security;

namespace Problem2_TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] command = input.Split();

                if (command[0] == "Loot")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        if (!initialLoot.Contains(command[i]))
                        {
                            initialLoot.Insert(0, command[i]);
                        }
                    }
                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < initialLoot.Count)
                    {
                        string item = initialLoot[index];
                        initialLoot.RemoveAt(index);
                        initialLoot.Add(item);
                    }
                }
                else if (command[0] == "Steal")
                {
                    int count = int.Parse(command[1]);

                    List<string> removedLoot = new List<string>();

                    for (int i = initialLoot.Count - 1; i >= initialLoot.Count - count; i--)
                    {
                        if (i < 0)
                        {
                            break;
                        }
                        removedLoot.Insert(0 ,initialLoot[i]);
                    }

                    for (int i = 0; i < removedLoot.Count; i++)
                    {
                        string currentItem = removedLoot[i];
                        initialLoot.Remove(currentItem);
                    }

                    Console.WriteLine(string.Join(", ", removedLoot));
                }
                input = Console.ReadLine();
            }

            if (initialLoot.Count > 0)
            {
                double average = 0;
                double totalLenght = 0;

                foreach (var item in initialLoot)
                {
                    totalLenght += item.Length;
                }

                average = totalLenght / initialLoot.Count;

                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
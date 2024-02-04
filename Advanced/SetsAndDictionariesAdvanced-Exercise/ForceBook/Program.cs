using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

namespace ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> sidesAndMembers = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                if (command.Contains('|'))
                {
                    string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    string currentSide = tokens[0];
                    string currentMember = tokens[1];

                    if (!sidesAndMembers.Values.Any(u => u.Contains(currentMember)))
                    {
                        if (!sidesAndMembers.ContainsKey(currentSide))
                        {
                            sidesAndMembers.Add(currentSide, new List<string>());
                        }

                        sidesAndMembers[currentSide].Add(currentMember);
                    }
                }
                else
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string currentSide = tokens[1];
                    string currentMember = tokens[0];

                    foreach (var sides in sidesAndMembers)
                    {
                        if (sides.Value.Contains(currentMember))
                        {
                            sides.Value.Remove(currentMember);
                            break;
                        }
                    }

                    if (!sidesAndMembers.ContainsKey(currentSide))
                    {
                        sidesAndMembers.Add(currentSide, new List<string>());
                    }
                    sidesAndMembers[currentSide].Add(currentMember);

                    Console.WriteLine($"{currentMember} joins the {currentSide} side!");
                }


                command = Console.ReadLine();
            }

            sidesAndMembers = sidesAndMembers.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in sidesAndMembers)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (var member in side.Value.OrderBy(x=> x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}

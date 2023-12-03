using System.Buffers;
using System.Text.RegularExpressions;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string bossName = Console.ReadLine();

                Regex regex = new Regex(@"\|(?<bossName>[A-Z]{4,})\|:#(?<title>[A-z]+ [A-z]+)#");

                Match match = regex.Match(bossName);

                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["bossName"].Value}, The {match.Groups["title"].Value}");
                    Console.WriteLine($">> Strength: {match.Groups["bossName"].Length}");
                    Console.WriteLine($">> Armor: {match.Groups["title"].Length}");
                }
                else
                {
                    Console.WriteLine($"Access denied!");
                }
            }
        }


    }
}
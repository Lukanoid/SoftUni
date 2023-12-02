using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine().ToUpper();

                char[] decryptedChars = new char[input.Length];
                int count = CountStarLetters(input);

                for (int j = 0; j < input.Length; j++)
                {
                    decryptedChars[j] = (char)(input[j] - count);
                }

                string decryptedInput = new string(decryptedChars).ToLower();

                Regex regex =
                    new Regex(
                        @"@(?<planetName>[A-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*\!(?<attackType>[a|d])![^@\-!:>]*->(?<soldiers>\d+)");

                Match match = regex.Match(decryptedInput);

                if (match.Success)
                {
                    string planetName = match.Groups["planetName"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string attackType = match.Groups["attackType"].Value;
                    int soldiers = int.Parse(match.Groups["soldiers"].Value);
                    

                    if (attackType == "a")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "d")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {char.ToUpper(attackedPlanet[0]) + attackedPlanet.Substring(1)}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {char.ToUpper(destroyedPlanet[0]) + destroyedPlanet.Substring(1)}");
            }
        }

        static int CountStarLetters(string message)
        {
            return Regex.Matches(message, "[sStTaArR]").Count();
        }
    }
}
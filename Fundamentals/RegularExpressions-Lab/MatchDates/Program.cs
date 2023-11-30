using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allDates = Console.ReadLine();

            Regex regex = new Regex(@"\b(?<day>\d{2})([/.-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");

            MatchCollection matches = regex.Matches(allDates);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                Regex regex =  new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d(.\d)]+)\$");

                Match match = regex.Match(input);

                if (regex.IsMatch(input))
                {
                    double currentPrice = double.Parse(match.Groups["price"].Value) *
                                          double.Parse(match.Groups["count"].Value);

                    totalIncome += currentPrice;

                    Console.WriteLine($"{match.Groups["customer"].Value}: {match.Groups["product"].Value} - {currentPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
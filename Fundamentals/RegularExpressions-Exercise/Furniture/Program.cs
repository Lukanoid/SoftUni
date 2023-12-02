using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> boughtFurniture = new List<string>();
            decimal sum = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(@">>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)");

                Match match = regex.Match(input);

                if (regex.IsMatch(input))
                {
                    string product = match.Groups["product"].Value;
                    boughtFurniture.Add(product);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal quantity = decimal.Parse(match.Groups["quantity"].Value);
                    decimal totalPrice = price * quantity;
                    sum += totalPrice;
                }
            }

            Console.WriteLine("Bought furniture:");

            for (int i = 0; i < boughtFurniture.Count; i++)
            {
                Console.WriteLine(boughtFurniture[i]);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
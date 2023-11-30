using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();

            Regex regex = new Regex(@"[+359]{4}([- ])[2]\1[\d]{3}\1[\d]{4}\b");

            MatchCollection matches = regex.Matches(phoneNumbers);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
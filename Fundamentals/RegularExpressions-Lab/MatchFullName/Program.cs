using System.Text.RegularExpressions;
using System.Xml;

namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection result = regex.Matches(text);

            
            foreach (Match match in result)
            {
                Console.Write(match + " ");
            }
        }
    }
}
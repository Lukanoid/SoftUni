using System.Text;

namespace DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            string allDigits = string.Empty;
            string allLeters = string.Empty;
            string allSymbols = string.Empty;

            foreach (var word in words)
            {
                if (char.IsDigit(word))
                {
                    allDigits += word;
                }
                else if (char.IsLetter(word))
                {
                    allLeters += word;
                }
                else
                {
                    allSymbols = word.ToString();
                }
 
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(allDigits);
            sb.AppendLine(allLeters);
            sb.AppendLine(allSymbols);

            Console.WriteLine(sb);
        }
    }
}
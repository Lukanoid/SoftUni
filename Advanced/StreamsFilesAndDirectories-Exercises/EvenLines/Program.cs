using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int count = 0;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversedWords = ReversedWords(replacedSymbols);
                        sb.AppendLine(reversedWords);
                    }
                    count++;
                }
            }
            return sb.ToString().TrimEnd();
        }

        private static string ReversedWords(string words)
        {
            string[] reversedWords = words
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
            
            return string.Join(" ", reversedWords);
        }

        public static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);

            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };

            foreach (var symbol in symbolsToReplace)
            {
                sb = sb.Replace(symbol, '@');
            }
            return sb.ToString();
        }

    }
}
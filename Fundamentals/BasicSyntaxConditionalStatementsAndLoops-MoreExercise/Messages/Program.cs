using System.Text;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            Dictionary<char, string> guide = new Dictionary<char, string>()
            {
                {'1' , "1"},
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"},
                {'0', " "},
            };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberOfLetters; i++)
            {
                string input = Console.ReadLine();

                sb.Append(CurrentLetter(guide, input));
            }

            Console.WriteLine(sb.ToString());
        }

        public static string CurrentLetter(Dictionary<char, string> guide, string input)
        {
            char leadNum = input[0];

            string combinedLetters = guide[leadNum];

            string currentLetter = combinedLetters.Substring(input.Length - 1, 1);
            return currentLetter;
        }
    }
}

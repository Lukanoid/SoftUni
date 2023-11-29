using System.Text;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
                while (i < input.Length - 1 && input[i] == input[i + 1])
                {
                    i++;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
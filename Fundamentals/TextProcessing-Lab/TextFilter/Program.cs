using System.Net.Sockets;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                int count = bannedWord.Length;
                text = text.Replace(bannedWord, new string('*', count));
            }

            Console.WriteLine(text);
        }
    }
}
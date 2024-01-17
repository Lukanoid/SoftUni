using System.Security.Cryptography.X509Certificates;

namespace ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> text = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                text.Push(input[i]);
            }

            while (text.Count != 0)
            {
                Console.Write(text.Pop());
            }
        }
    }
}

using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, bool> function = s => char.IsUpper(s[0]);

            text = text.Where(function).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, text));

        }
    }
}

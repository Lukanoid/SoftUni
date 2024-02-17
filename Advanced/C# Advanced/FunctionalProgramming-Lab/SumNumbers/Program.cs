using System.Security.Cryptography;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(input.Count);
            Console.WriteLine(input.Sum());
        }
    }
}

using System.Threading.Channels;

namespace KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<string> appendPrefix = str => Console.WriteLine($"Sir {str}");

            names.ForEach(appendPrefix);
        }

    }
}

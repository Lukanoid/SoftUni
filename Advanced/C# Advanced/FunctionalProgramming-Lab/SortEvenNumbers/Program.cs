namespace SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x=> x % 2 == 0)
                .OrderBy(x=> x)
                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}

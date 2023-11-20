namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (!sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers.Add(number, 1);
                }
                else
                {
                    sortedNumbers[number]++;
                }
            }

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }


    }
}
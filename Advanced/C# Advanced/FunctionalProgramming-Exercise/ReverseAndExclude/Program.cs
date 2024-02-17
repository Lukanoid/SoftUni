namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> function = (numbers, n) =>
            {
                List<int> result = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % n != 0)
                    {
                        result.Add(numbers[i]);
                    }
                }
                return result;
            };

            numbers = function(numbers, n);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

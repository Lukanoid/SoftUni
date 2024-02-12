namespace CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>, int> function = MinNumber;

            int number = function(numbers);

            Console.WriteLine(number);
        }

        static int MinNumber(List<int> numbers)
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            return minNumber;
        }



    }
}

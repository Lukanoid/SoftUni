namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int[] bombAndPower = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            while (numbers.Contains(bomb))
            {
                int bombPosition = numbers.IndexOf(bomb);
                int start = bombPosition - power;
                if (start < 0)
                {
                    start = 0;
                }
                int end = bombPosition + power;
                if (end > numbers.Count - 1)
                {
                    end = numbers.Count - 1;
                }
                numbers.RemoveRange(start, end - start + 1);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
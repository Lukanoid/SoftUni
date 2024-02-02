namespace Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(n => n).ToList();

            if (input.Count < 4)
            {
                foreach (var number in input)
                {
                    Console.Write(number + " ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}

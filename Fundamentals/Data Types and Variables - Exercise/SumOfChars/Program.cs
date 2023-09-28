namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = default;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());

                num = (int)input;
                sum += num;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
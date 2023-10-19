namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractAndSum(first, second, third));
        }

        static int SubtractAndSum(int first, int second, int third)
        {
            int sum = first + second;
            sum -= third;
            return sum;
        }

    }
}
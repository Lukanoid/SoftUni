namespace RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] items = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {(int)Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
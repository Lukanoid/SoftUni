namespace SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            int[] numbers = new int[items.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
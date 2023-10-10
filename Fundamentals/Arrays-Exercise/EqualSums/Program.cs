namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rightsum = 0;
            int leftsum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftsum = 0;
                rightsum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(j > i)
                    {
                        rightsum += numbers[j];
                    }
                    else if (j < i)
                    {
                        leftsum += numbers[j];
                    }
                }
                if(leftsum == rightsum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            if(rightsum != leftsum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
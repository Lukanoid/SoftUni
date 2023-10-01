namespace EvenAndOddSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int evenSum = default;
            int oddSum = default;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if(currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
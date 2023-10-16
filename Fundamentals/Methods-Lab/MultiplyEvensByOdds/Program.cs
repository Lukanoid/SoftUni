using System.Linq;

namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            int sumOfEvenDigits = GetSumOfEvenDigits(number);
            int sumOfOddDigits = GetSumOfOddDigits(number);

            Console.WriteLine(sumOfOddDigits * sumOfEvenDigits);
        }

        private static int GetSumOfOddDigits(int number)
        {
            string numberString = number.ToString();

            int sum = 0;

            foreach (var digit in numberString)
            {
                int digitValue;

                if (int.TryParse(digit.ToString(), out digitValue) && digitValue % 2 != 0)
                {
                    sum += digitValue;
                }
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            string numberString = number.ToString();

            int sum = 0;

            foreach (var digit in numberString)
            {
                int digitValue;
                if (int.TryParse(digit.ToString(), out digitValue) && digitValue % 2 == 0)
                {
                    sum += digitValue;
                }
            }
            return sum;
        }
    }
}
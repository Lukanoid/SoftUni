namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine());
            decimal second = decimal.Parse(Console.ReadLine());
            decimal result = FirstFactorial(first) / SecondFactorial(second);

            Console.WriteLine($"{result:f2}");

        }

        static decimal FirstFactorial(decimal first)
        {
            for (decimal i = first - 1 ; i > 0; i--)
            {
                first *= i;
            }

            return first;
        }

        static decimal SecondFactorial(decimal second)
        {
            for (decimal i = second - 1; i > 0; i--)
            {
                second *= i;
            }

            return second;
        }
    }
}
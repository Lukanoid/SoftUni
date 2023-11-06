using System.Numerics;

namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = int.Parse(Console.ReadLine());

            for (BigInteger i = n - 1; i >= 1; i--)
            {
                n *= i;
            }

            Console.WriteLine(n);
        } 
    }
}
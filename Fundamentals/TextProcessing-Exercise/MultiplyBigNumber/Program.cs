namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().Trim().TrimStart('0');
            int singleDigit = int.Parse(Console.ReadLine());

            if (singleDigit == 0 || bigNumber.All(x => x == '0'))
            {
                Console.WriteLine(0);
                return;
            }

            int[] productArray = new int[bigNumber.Length + 1];

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = bigNumber[i] - '0';

                int product = digit * singleDigit;

                productArray[i + 1] += product;

                if (productArray[i + 1] >= 10)
                {
                    productArray[i] += productArray[i + 1] / 10;
                    productArray[i + 1] %= 10;
                }
            }

            string result = string.Concat(productArray).Trim('0');
            Console.WriteLine(result);
        }
    }
}
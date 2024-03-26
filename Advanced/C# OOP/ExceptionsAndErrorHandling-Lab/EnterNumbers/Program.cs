namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                string charater = Console.ReadLine();
                try
                {
                    numbers[i] = ReadNumber(charater, i);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
        
        public static int ReadNumber(string number, int i)
        {
            int start = i + 1;
            int end = 100;

            if (!number.All(x=> char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid Number!");
            }

            if (int.Parse(number) <= start || int.Parse(number) >= end)
            {
                throw new Exception($"Your number is not in range {start} - 100!");
            }

            return int.Parse(number);
        }
    }
}

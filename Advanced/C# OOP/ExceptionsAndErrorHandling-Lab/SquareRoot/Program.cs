namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(CalculateSquareRoot(number));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        }

        public static double CalculateSquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            return Math.Sqrt(number);
        }
    }
}

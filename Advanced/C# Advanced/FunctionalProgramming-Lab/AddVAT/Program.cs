namespace AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> function = p => p += p * 0.2;

            List<double> prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (var price in prices)
            {
                double priceWithVat = function(price);
                Console.WriteLine($"{priceWithVat:F2}");
            }

        }
    }
}

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalprice = 0;

            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = days * capsulesCount * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                totalprice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalprice:F2}");
        }
    }
}
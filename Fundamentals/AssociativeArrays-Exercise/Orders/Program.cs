using System.IO.Pipes;
using System.Reflection.Metadata;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] inputAsArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentProduct = inputAsArray[0];
                double price = double.Parse(inputAsArray[1]);
                double quantity = double.Parse(inputAsArray[2]);

                if (!products.ContainsKey(currentProduct))
                {
                    products.Add(currentProduct, new []{price, quantity});
                }
                else
                {
                    if (products[currentProduct].ElementAt(0) != price)
                    {
                        products[currentProduct][0] = price;
                    }
                    products[currentProduct][1] += quantity;
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.ElementAt(0) * product.Value.ElementAt(1):f2}");
            }
        }
    }
}
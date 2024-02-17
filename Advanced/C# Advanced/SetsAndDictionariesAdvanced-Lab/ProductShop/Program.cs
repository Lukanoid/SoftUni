
namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> allShops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Revision")
                {
                    break;
                }

                string[] data = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string currentShop = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!allShops.ContainsKey(currentShop))
                {
                    allShops.Add(currentShop, new Dictionary<string, double>());
                    allShops[currentShop].Add(product, price);
                }
                else
                {
                    if (!allShops[currentShop].ContainsKey(product))
                    {
                        allShops[currentShop].Add(product, price);
                    }
                }
            }

            allShops = allShops.OrderBy(x => x.Key).ToDictionary(t => t.Key, t=> t.Value);
            foreach (var shop in allShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}

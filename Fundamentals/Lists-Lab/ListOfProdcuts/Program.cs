namespace ListOfProdcuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 1; i <= productsCount; i++)
            {
                string input = Console.ReadLine();
                products.Add(input);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
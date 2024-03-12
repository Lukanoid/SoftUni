using ShoppingSpree.Models;

namespace ShoppingSpree
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> allProducts = new List<Product>();

            for (int i = 0; i < names.Length; i += 2)
            {
                try
                {
                    Person person = new Person(names[i], decimal.Parse(names[i + 1]));
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            for (int i = 0; i < products.Length; i += 2)
            {
                try
                {
                    Product product = new Product(products[i], decimal.Parse(products[i + 1]));
                    allProducts.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string product = tokens[1];

                Person person = people.FirstOrDefault(p => p.Name == name);
                Product currentProduct = allProducts.FirstOrDefault(p => p.Name == product);

                if (person != null && currentProduct != null)
                {
                    Console.WriteLine(person.Add(currentProduct));
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}

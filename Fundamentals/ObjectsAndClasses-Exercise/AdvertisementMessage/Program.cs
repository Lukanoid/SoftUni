using System.Reflection.Emit;

namespace AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
             
            int n = int.Parse(Console.ReadLine());

            string[] phrases = new string [] {"Excellent product.", "Such a great product.","I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = new string [] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string [] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[rand.Next(phrases.Length)];
                string @event = events[rand.Next(events.Length)];
                string author = authors[rand.Next(authors.Length)];
                string city = cities[rand.Next(cities.Length)];

                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }

            
        }

    }

}
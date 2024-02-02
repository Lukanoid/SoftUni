namespace CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countryInfo =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int numberOfCountries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCountries; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string continent = info[0];
                string country = info[1];
                string town = info[2];

                if (!countryInfo.ContainsKey(continent))
                {
                    countryInfo.Add(continent, new Dictionary<string, List<string>>());
                    countryInfo[continent].Add(country, new List<string>());
                    countryInfo[continent][country].Add(town);
                }
                else
                {
                    if (!countryInfo[continent].ContainsKey(country))
                    {
                        countryInfo[continent].Add(country, new List<string>());
                        countryInfo[continent][country].Add(town);
                    }
                    else
                    {
                        countryInfo[continent][country].Add(town);
                    }
                }
            }

            foreach (var element in countryInfo)
            {
                Console.WriteLine($"{element.Key}:");
                foreach (var item in element.Value)
                {
                    Console.Write($"{item.Key} -> ");
                    Console.WriteLine(string.Join(", ", item.Value));
                }
            }

        }
    }
}

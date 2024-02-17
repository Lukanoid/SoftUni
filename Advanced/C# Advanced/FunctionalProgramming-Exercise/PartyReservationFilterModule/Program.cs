namespace PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action == "Add filter")
                {
                    if (!filters.ContainsKey(value + value))
                    {
                        filters.Add(filter + value, GetPredicate(filter, value));    
                    }
                }
                else
                {
                    filters.Remove(filter + value);
                }
            }

            foreach (var predicate in filters)
            {
                people.RemoveAll(predicate.Value);
            }

            Console.WriteLine($"{string.Join(" ", people)}");

            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "Starts with":
                        return p => p.StartsWith(value);
                    case "Ends with":
                        return p => p.EndsWith(value);
                    case "Length":
                        return p => p.Length == int.Parse(value);
                    case "Contains":
                        return p => p.Contains(value);
                    default:
                        return default;
                }
            }
        }
    }
}

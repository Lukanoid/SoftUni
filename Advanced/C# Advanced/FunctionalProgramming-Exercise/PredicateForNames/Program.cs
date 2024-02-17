namespace PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<string>, int, List<string>> function = (names, wordLenght) =>
            {
                List<string> result = new List<string>();

                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Length <= wordLenght)
                    {
                        result.Add(names[i]);
                    }
                }
                return result;
            };

            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            names = function(names, n);

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}

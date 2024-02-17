using System.Reflection;

namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, List<int>> range = end =>
            {
                List<int> numbers = new List<int>();

                for (int i = 1; i <= end; i++)
                {
                    numbers.Add(i);
                }

                return numbers;
            };
            List<Predicate<int>> predicates = new();

            int n = int.Parse(Console.ReadLine());

            List<int> numbers = range(n);

            HashSet<int> sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

            foreach (var number in sequence)
            {
                predicates.Add(n=> n % number == 0);
            }

            foreach (var number in numbers)
            {
                bool isDivisible = true;
                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}

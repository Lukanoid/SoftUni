namespace FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int start = range[0];
            int end = range[1];
            List<int> numbers = Enumerable.Range(start, end - start + 1).ToList();
            

            string command = Console.ReadLine();

            Predicate<string> evenOrOdd = str =>
            {
                if (str == "odd")
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            };

            if (evenOrOdd(command))
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
            else if (!evenOrOdd(command))
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
        } 
    }
}

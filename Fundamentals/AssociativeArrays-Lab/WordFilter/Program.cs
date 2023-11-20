namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string[] filterWords = words.Where(x => x.Length % 2 == 0).ToArray();

            foreach (var filterWord in filterWords)
            {
                Console.WriteLine(filterWord);
            }
        }
    }
}
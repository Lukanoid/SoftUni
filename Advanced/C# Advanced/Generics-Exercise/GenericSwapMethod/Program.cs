namespace GenericSwapMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> words = new List<int>();    

            for (int i = 0; i < n; i++)
            {
                int currentWord = int.Parse(Console.ReadLine());

                words.Add(currentWord);
            }

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Swap(words, indexes[0], indexes[1]);

            foreach (var word in words)
            {
                Console.WriteLine($"{word.GetType()}: {word}");
            }
        }

        static void Swap<T>(List<T> words, int first, int second)
        {
            (words[first], words[second]) = (words[second], words[first]);
        }
    }
}

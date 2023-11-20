namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> allWords = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!allWords.ContainsKey(word))
                {
                    allWords.Add(word, new List<string>());
                    allWords[word].Add(synonym);
                }
                else
                {
                    allWords[word].Add(synonym);
                }
            }

            foreach (var word in allWords)
            {
                List<string> synonymList = word.Value;
                Console.WriteLine($"{word.Key} - {string.Join(", ", synonymList)}");
            }
        }
    }
}
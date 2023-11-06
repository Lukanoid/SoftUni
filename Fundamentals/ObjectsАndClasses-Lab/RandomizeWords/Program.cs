namespace RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length; i++)
            {
                Random  random = new Random();
                int randomIndex = random.Next(0, words.Length);

                string currentWord = words[i];
                string wordToSwap = words[randomIndex];

                words[i] = wordToSwap;
                words[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }

}
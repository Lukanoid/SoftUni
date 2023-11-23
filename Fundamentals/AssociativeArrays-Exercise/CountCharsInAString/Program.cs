namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] arr;

            arr = input.ToCharArray();
            
            Dictionary<char, int> words = new Dictionary<char, int>();

            foreach (var symbol in arr)
            {
                if (symbol != 32)
                {
                    if (!words.ContainsKey(symbol))
                    {
                        words.Add(symbol, 1);
                    }
                    else
                    {
                        words[symbol]++;
                    }
                }
            }

            foreach (var word in words) 
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}
using System.Text.Json;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Console.WriteLine(TotalSum(words));
        }

        public static int TotalSum(string[] words)
        {
            int sum = 0;
            char[] firstWord = words[0].ToCharArray();
            char[] secondWord = words[1].ToCharArray();
            if (words[0].Length == words[1].Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
            }
            else if (words[0].Length > words[1].Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (i > secondWord.Length - 1)
                    {
                        sum += firstWord[i];
                    }
                    else
                    {
                        sum += firstWord[i] * secondWord[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (i > firstWord.Length - 1)
                    {
                        sum += secondWord[i];
                    }
                    else
                    {
                        sum += firstWord[i] * secondWord[i];
                    }
                }
            }

            return sum;
        }
    }
}
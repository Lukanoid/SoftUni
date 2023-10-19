/*
 a, e, i, o, u
 *
 *
 */


namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = GetNumberOfVowels(input);
            Console.WriteLine(result);
        }

        static int GetNumberOfVowels(string word)
        {
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    sum++;
                }
                else if (word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
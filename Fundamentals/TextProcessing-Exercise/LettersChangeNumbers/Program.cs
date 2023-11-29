using System.Reflection.Metadata.Ecma335;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequences = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0;

            for (int i = 0; i < sequences.Length; i++)
            {
                char[] currentSequence = sequences[i].ToCharArray();
                List<char> currentNum = new List<char>();

                for (int j = 0; j < currentSequence.Length; j++)
                {
                    if (currentSequence[j] > '0' && currentSequence[j] <= '9')
                    {
                        currentNum.Add(currentSequence[j]);
                    }
                }

                string numberAsString = string.Join("", currentNum.ToArray());
                decimal number = decimal.Parse(numberAsString);

                for (int j = 0; j < currentSequence.Length; j++)
                {
                    if (j == 0 && char.IsUpper(currentSequence[j]))
                    {
                        int currentPosition = GetLetterInTheAlphabet(currentSequence[j]);
                        number /= currentPosition;
                    }
                    else if (j == 0 && char.IsLower(currentSequence[j]))
                    {
                        int currentPosition = GetLetterInTheAlphabet(currentSequence[j]);
                        number *= currentPosition;
                    }
                    else if (j != 0 && char.IsUpper(currentSequence[j]))
                    {
                        int currentPosition = GetLetterInTheAlphabet(currentSequence[j]);
                        number -= currentPosition;
                    }
                    else if (j != 0 && char.IsLower(currentSequence[j]))
                    {
                        int currentPosition = GetLetterInTheAlphabet(currentSequence[j]);
                        number += currentPosition;
                    }
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");


        }

        static int GetLetterInTheAlphabet(char c)
        {
            return c.ToString().ToLower().First() - 96;
        }
    }
}
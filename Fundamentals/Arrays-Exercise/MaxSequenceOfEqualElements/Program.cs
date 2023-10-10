using System.Globalization;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int longestSequenceStartIndex = 0;
            int longestSequenceLenght = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int currentSequenceStartIndex = i - 1;
                int currentSequenceLenght = 1;

                while (i < arr.Length && arr[i] == arr[i - 1])
                {
                    currentSequenceLenght++;
                    i++;
                }

                if (currentSequenceLenght > longestSequenceLenght)
                {
                    longestSequenceLenght = currentSequenceLenght;
                    longestSequenceStartIndex = currentSequenceStartIndex;
                }
            }

            for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLenght; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
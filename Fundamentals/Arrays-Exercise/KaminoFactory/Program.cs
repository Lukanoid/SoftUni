/*
 5
1!0!1!1!0
0!1!1!0!0
Clone them!
 
 
 */


namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            int[] currentLongestSequence = new int[dnaLenght];
            int currentSequenceLenght = 0;
            int currentStartingIndex = 0;
            int currentSum = 0;
            int dnaNumber = 0;

            int counter = 0;

            while (true)
            {
                counter++;
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] array = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
                int lenght = 0;

                foreach (var item in array)
                {
                    if (item == 1)
                    {
                        lenght++;
                    }
                    else if (item == 0 && lenght > 0)
                    {
                        break;
                    }
                }

                int startingIndex = Array.IndexOf(array, 1);
                int sum = array.Sum();

                if (lenght > currentSequenceLenght 
                    || lenght == currentSequenceLenght && currentStartingIndex > startingIndex
                    || lenght == currentStartingIndex && currentStartingIndex == startingIndex && sum > currentSum)
                {
                    currentLongestSequence = array;
                    currentSequenceLenght = lenght;
                    currentStartingIndex = startingIndex;
                    currentSum = sum;
                    dnaNumber = counter;
                }
            }

            Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {currentSum}.");
            Console.WriteLine(string.Join(' ', currentLongestSequence));
        }
    }
}
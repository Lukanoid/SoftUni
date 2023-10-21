namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {

                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.RemoveAt(0);
                    firstDeck.Add(secondDeck[0]);
                    secondDeck.RemoveAt(0);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.RemoveAt(0);
                    secondDeck.Add(firstDeck[0]);
                    firstDeck.RemoveAt(0);
                }
                else if (firstDeck[0] == secondDeck[0])
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }

            int firstSum = firstDeck.Sum();
            int secondSum = secondDeck.Sum();

            if (firstSum > secondSum)
            {
                Console.WriteLine($"First player wins! Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondSum}");
            }
        }

    }
}
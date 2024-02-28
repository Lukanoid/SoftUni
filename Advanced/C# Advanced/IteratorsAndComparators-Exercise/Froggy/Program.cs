namespace Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separator = new[] { ' ', ',' };
            int[] stones = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Lake lake = new Lake(stones.ToList());

            List<int> oddStones = new List<int>();
            List<int> evenStones = new List<int>();

            foreach (var stone in lake)
            {
                if (stone % 2 == 0)
                {
                    evenStones.Add(stone);
                }
                else
                {
                    oddStones.Add(stone);
                }
            }

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}

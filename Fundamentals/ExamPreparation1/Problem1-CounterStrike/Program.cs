namespace Problem1_CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int winsCount = 0;
            bool isEnergyEnough = true;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                
                int distance = int.Parse(input);

                if (energy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {energy} energy");
                    isEnergyEnough = false;
                    break;
                }

                energy -= distance;
                winsCount++;

                if (winsCount % 3 == 0)
                {
                    energy += winsCount;
                }
                input = Console.ReadLine();
            }

            if (isEnergyEnough)
            {
                Console.WriteLine($"Won battles: {winsCount}. Energy left: {energy}");
            }

        }
    }
}
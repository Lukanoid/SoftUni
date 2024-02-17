namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<int[]> allPumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                 int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                allPumps.Enqueue(data);
            }

            int position = 0;

            while (true)
            {
                int fuel = 0;
                foreach (var pump in allPumps)
                {
                    fuel += pump[0] - pump[1];
                    if (fuel < 0)
                    {
                        position++;
                        allPumps.Enqueue(allPumps.Dequeue());
                        break; 
                    }
                }

                if (fuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(position);
        }

    }
}

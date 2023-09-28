namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                capacity += liters;

                if (capacity > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    capacity -= liters;
                    continue;
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
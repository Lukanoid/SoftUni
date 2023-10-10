namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalPassengers = 0;
            int[] passengers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                passengers[i] = input;
                totalPassengers += input;
            }

            foreach (var passenger in passengers)
            {
                Console.Write(passenger + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPassengers);
        }
    }
}
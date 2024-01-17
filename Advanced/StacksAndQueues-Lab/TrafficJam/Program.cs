namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int carsPassed = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}

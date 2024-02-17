namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (command != "END")
            {
                string[] data = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "IN")
                {
                    cars.Add(data[1]);
                }
                else
                {
                    cars.Remove(data[1]);
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

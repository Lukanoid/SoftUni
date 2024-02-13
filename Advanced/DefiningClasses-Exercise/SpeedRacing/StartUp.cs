namespace SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                allCars.Add(model, car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = data[1];
                int kilometers = int.Parse(data[2]);

                allCars[model].Drive(kilometers);

                command = Console.ReadLine();
            }

            foreach (var car in allCars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

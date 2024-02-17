namespace CarManufacturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tireInput = Console.ReadLine();
            List<Tire[]> allTires = new List<Tire[]>();
            List<Engine> allEngines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (tireInput != "No more tires")
            {
                string[] tireData = tireInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Tire[] tires = new Tire[4]
                {
                    new Tire(int.Parse(tireData[0]), double.Parse(tireData[1])),
                    new Tire(int.Parse(tireData[2]), double.Parse(tireData[3])),
                    new Tire(int.Parse(tireData[4]), double.Parse(tireData[5])),
                    new Tire(int.Parse(tireData[6]), double.Parse(tireData[7]))
                };
                allTires.Add(tires);

                tireInput = Console.ReadLine();
            }

            string engineInput = Console.ReadLine();

            while (engineInput != "Engines done")
            {
                string[] engineData = engineInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(engineData[0]), double.Parse(engineData[1]));
                allEngines.Add(engine);

                engineInput = Console.ReadLine();
            }

            string input;

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Tire[] tire = allTires.ElementAt(int.Parse(carInfo[5]));
                Engine engine = allEngines.ElementAt(int.Parse(carInfo[6]));

                cars.Add(new Car
                {
                    Make = make,
                    Model = model,
                    Year = year,
                    FuelQuantity = fuelQuantity,
                    FuelConsumption = fuelConsumption,
                    Tires = tire,
                    Engine = engine
                });
            }

            List<Car> specialCars = cars.Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 &&
                                                      car.Tires.Sum(tire => tire.Pressure) >= 9 &&
                                                      car.Tires.Sum(tire => tire.Pressure) <= 10)
                                                      .ToList();

            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}

namespace RawData
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                


                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];

                Tires[] tires = new Tires[4]
                {
                    new Tires(double.Parse(carData[5]), int.Parse(carData[6])),
                    new Tires(double.Parse(carData[7]), int.Parse(carData[8])),
                    new Tires(double.Parse(carData[9]), int.Parse(carData[10])),
                    new Tires(double.Parse(carData[11]), int.Parse(carData[12]))
                };
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(model, engine, cargo, tires);
                allCars.Add(car);
            }

            string printCargoType = Console.ReadLine();

            List<Car> sortedCars = new List<Car>();

            if (printCargoType == "fragile")
            {
                sortedCars = allCars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(x => x.Pressure < 1) ).ToList();
            }
            else
            {
                sortedCars = allCars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).ToList();
            }

            foreach (Car car in sortedCars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}

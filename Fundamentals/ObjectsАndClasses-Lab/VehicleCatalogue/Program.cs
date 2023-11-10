namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            string commandInfo = Console.ReadLine();

            while (commandInfo != "end")
            {
                string[] vehicleInfo = commandInfo.Split("/");

                string type = vehicleInfo[0];
                string make = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = make;
                    car.Model = model;
                    car.HorsePower = value;

                    catalogue.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = make;
                    truck.Model = model;
                    truck.Weight = value;

                    catalogue.Trucks.Add(truck);
                }

                commandInfo = Console.ReadLine();
            }


            Console.WriteLine("Cars:");
            foreach (var car in catalogue.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalogue.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

}
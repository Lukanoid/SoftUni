namespace Vehicles
{
    public class Engine : IEngine
    {
        List<IDrivable> vehicles;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            vehicles = new List<IDrivable>();
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
            vehicles.Add(CreateVehicles());
            vehicles.Add(CreateVehicles());
            vehicles.Add(CreateVehicles());

            int n = int.Parse(reader.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    ProcessInput();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }
        }

        private IDrivable CreateVehicles()
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return vehicleFactory.Create(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]),
                double.Parse(tokens[3]));
        }

        private void ProcessInput()
        {
            string[] command = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IDrivable vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == command[1]);
            double number = double.Parse(command[2]);

            if (vehicle != null)
            {
                if (command[0] == "Drive")
                {
                    vehicle.Drive(number, true);
                }
                else if (command[0] == "DriveEmpty")
                {
                    vehicle.Drive(number, false);
                }
                else
                {
                    vehicle.Refuel(number);
                }

            }
        }
    }
}

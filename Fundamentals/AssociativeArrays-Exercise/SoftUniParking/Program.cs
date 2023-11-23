using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;

namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> vehicles = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "register")
                {
                    if (!vehicles.ContainsKey(data[1]))
                    {
                        vehicles.Add(data[1], data[2]);
                        Console.WriteLine($"{data[1]} registered {data[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {data[2]}");
                    }
                }
                else if (data[0] == "unregister")
                {
                    if (!vehicles.ContainsKey(data[1]))
                    {
                        Console.WriteLine($"ERROR: user {data[1]} not found");
                    }
                    else
                    {
                        vehicles.Remove(data[1]);
                        Console.WriteLine($"{data[1]} unregistered successfully");
                    }
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Key} => {vehicle.Value}");
            }
        }
    }
}
using System.Diagnostics;
using System.Globalization;

namespace SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> travelRoute = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelRoute.Count; i++)
            {
                string[] command = travelRoute[i].Split();
                if (command[0] == "Travel")
                {
                    int distanceTraveled = int.Parse(command[1]);
                    fuel -= distanceTraveled;

                    if (fuel >= 0)
                    {
                        Console.WriteLine($"The spaceship travelled {distanceTraveled} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (command[0] == "Enemy")
                {
                    int enemyArmour = int.Parse(command[1]);

                    if (ammunition >= enemyArmour)
                    {
                        ammunition -= enemyArmour;
                        Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
                    }
                    else
                    {
                        int fuelConsumed = enemyArmour * 2;
                        fuel -= fuelConsumed;
                        if (fuel >= 0)
                        {
                            Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int amount = int.Parse(command[1]);
                    fuel += amount;
                    ammunition += amount * 2;
                    Console.WriteLine($"Ammunitions added: {amount * 2}.");
                    Console.WriteLine($"Fuel added: {amount}.");
                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    break;
                }
            }
        }
    }
}
using System;
using System.ComponentModel.Design;
using System.Timers;

namespace CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string type = string.Empty;
            string carType = string.Empty;
            double priceForCar = 0;

            if (budget <= 100)
            {
                type = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    priceForCar = budget * 0.35;
                }
                else
                {
                    carType = "Jeep";
                    priceForCar = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                type = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    priceForCar = budget * 0.45;
                }
                else
                {
                    carType = "Jeep";
                    priceForCar = budget * 0.8;
                }
            }
            else
            {
                type = "Luxury class";
                carType = "Jeep";
                priceForCar = budget * 0.9;
            }
            Console.WriteLine(type);
            Console.WriteLine($"{carType} - {priceForCar:f2}");
        }
    }
}
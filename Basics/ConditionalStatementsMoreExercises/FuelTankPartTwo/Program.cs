using System;

namespace FuelTankPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litersOfFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double pricePerLiter = 0; 

            if (clubCard == "Yes")
            {
                switch (fuel)
                {
                    case "Gasoline":
                        pricePerLiter = 2.04;
                        break;
                    case "Gas":
                        pricePerLiter = 0.85;
                        break;
                    case "Diesel":
                        pricePerLiter = 2.21;
                        break;
                }
            }
            else
            {
                switch (fuel)
                {
                    case "Gasoline":
                        pricePerLiter = 2.22;
                        break;
                    case "Gas":
                        pricePerLiter = 0.93;
                        break;
                    case "Diesel":
                        pricePerLiter = 2.33;
                        break;
                }
            }
            double totalPrice = pricePerLiter * litersOfFuel;

            if (litersOfFuel > 20 && litersOfFuel <= 25)
            {
                totalPrice *= 0.92;
            }
            else if (litersOfFuel > 25)
            {
                totalPrice *= 0.9;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
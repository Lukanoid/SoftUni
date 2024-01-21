using System;

namespace TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double pricePerKm = 0;

            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.75;
                        break;
                    case "Summer":
                        pricePerKm = 0.9;
                    break;
                    default:
                        pricePerKm = 1.05;
                        break;
                }
            }
            else if(kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.95;
                    break;
                    case "Summer":
                        pricePerKm = 1.1;
                        break;
                    default:
                        pricePerKm = 1.25;
                        break;
                }
            }
            else
            {
                pricePerKm = 1.45;
            }
            double salary = (kmPerMonth * pricePerKm) * 4;
            double salaryAfterTax = salary * 0.9;
            Console.WriteLine($"{salaryAfterTax:f2}");
        }
    }
}
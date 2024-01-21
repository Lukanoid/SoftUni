using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accomodation = string.Empty;
            string location = string.Empty;
            double priceForTrip = 0;

            if(budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    priceForTrip = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    priceForTrip = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                accomodation = "Hut";
                if(season == "Summer")
                {
                    location = "Alaska";
                    priceForTrip = budget * 0.8;
                }
                else
                {
                    location = "Morocco";
                    priceForTrip = budget * 0.6;
                }
            }
            else
            {
                accomodation = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
                priceForTrip = budget * 0.9;
            }
            Console.WriteLine($"{location} - {accomodation} - {priceForTrip:f2}");
        }
    }
}
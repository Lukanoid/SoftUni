using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double priceforjourney = 0;
            string type = "";




            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        priceforjourney = budget * 0.3;
                        break;
                    case "winter":
                        priceforjourney = budget * 0.7;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch(season)
                {
                    case "summer":
                        priceforjourney = budget * 0.4;
                        break;
                    case "winter":
                        priceforjourney = budget * 0.8;
                        break;
                }
            }
            else
            {
                destination = "Europe";
                priceforjourney = budget * 0.9;
            }
            if (season == "summer" && destination != "Europe")
                type = "Camp";
            else
                type = "Hotel";
            Console.WriteLine("Somewhere in " + destination);
            Console.WriteLine($"{type} - {priceforjourney:f2}");
        }
    }
}
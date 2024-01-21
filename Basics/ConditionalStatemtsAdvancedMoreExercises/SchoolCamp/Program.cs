using System;

namespace SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            string sport = string.Empty;

            if (type == "mixed")
            {
                switch(season)
                {
                    case "Winter":
                        pricePerNight = 10;
                        sport = "Ski";
                        break;
                    case "Spring":
                        pricePerNight = 9.5;
                        sport = "Cycling";
                        break;
                    case "Summer":
                        pricePerNight = 20;
                        sport = "Swimming";
                        break;
                }
            }
            else if (type == "boys")
            {
                switch(season)
                {
                    case "Winter":
                        pricePerNight = 9.6;
                        sport = "Judo";
                        break;
                    case "Spring":
                        pricePerNight = 7.2;
                        sport = "Tennis";
                        break;
                    case "Summer":
                        pricePerNight = 15;
                        sport = "Football";
                        break;
                }
            }
            else if (type == "girls")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 9.6;
                        sport = "Gymnastics";
                        break;
                    case "Spring":
                        pricePerNight = 7.2;
                        sport = "Athletics";
                        break;
                    case "Summer":
                        pricePerNight = 15;
                        sport = "Volleyball";
                        break;
                }
            }
            double price = (numberOfNights * pricePerNight) * numberOfStudents;
            if (numberOfStudents >= 50)
            {
                price *= 0.5;
            }
            else if (numberOfStudents >= 20)
            {
                price *= 0.85;
            }
            else if (numberOfStudents >= 10)
            {
                price *= 0.95;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
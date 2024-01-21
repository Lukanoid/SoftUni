using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForAppartment = 0; 

            if (month == "May" || month == "October")
            {
                priceForStudio = 50;
                priceForAppartment = 65;
            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 75.2;
                priceForAppartment = 68.7;
            }
            else
            {
                priceForStudio = 76;
                priceForAppartment = 77;
            }
            double totalPriceForStudio = numberOfNights * priceForStudio;
            double totalPriceForApp = numberOfNights * priceForAppartment;

            switch (month)
            {
                case "May":
                case "October":
                    if (numberOfNights > 7 && numberOfNights < 15)
                    {
                        totalPriceForStudio *= 0.95;
                    }
                    else if (numberOfNights > 14)
                    {
                        totalPriceForStudio *= 0.7;
                    }
                    break;
                case "June":
                case "September":
                    if (numberOfNights > 14)
                    {
                        totalPriceForStudio *= 0.8;
                    }
                    break;               
            }
            if (numberOfNights > 14)
            {
                totalPriceForApp *= 0.9;
            }
            Console.WriteLine($"Apartment: {totalPriceForApp:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceForStudio:f2} lv.");
        }
    }
}
using System;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberChrysanthemums = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;

            switch (season)
            {
                case "Summer":
                case "Spring":
                    chrysanthemumsPrice = 2;
                    rosesPrice = 4.1;
                    tulipsPrice = 2.5;
                break;
                default:
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.5;
                    tulipsPrice = 4.15;
                    break;
            }
            double flowersNumber = numberChrysanthemums + numberRoses + numberTulips;
            double bouquetPrice = (numberChrysanthemums * chrysanthemumsPrice) + (numberRoses * rosesPrice) + (numberTulips * tulipsPrice); 
            if (holiday == "Y")
            {
                bouquetPrice += bouquetPrice * 0.15;
            }
            if (numberTulips > 7 && season == "Spring")
            {
                bouquetPrice *= 0.95;
            }
            if (numberRoses >= 10 && season == "Winter")
            {
                bouquetPrice *= 0.9;
            }
            if (flowersNumber > 20)
            {
                bouquetPrice *= 0.8;
            }
            Console.WriteLine($"{bouquetPrice + 2:f2}");
        }
    }
}
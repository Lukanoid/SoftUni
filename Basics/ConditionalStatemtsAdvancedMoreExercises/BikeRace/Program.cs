using System;

namespace BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double juniorsTax = 0;
            double seniorsTax = 0;

            switch (type)
            {
                case "trail":
                    juniorsTax = 5.5;
                    seniorsTax = 7;
                    break;
                case "cross-country":
                    if (juniors + seniors >= 50)
                    {
                        juniorsTax = 6;
                        seniorsTax = 7.125;
                        break;
                    }
                    juniorsTax = 8;
                    seniorsTax = 9.5;
                    break;
                case "downhill":
                    juniorsTax = 12.25;
                    seniorsTax = 13.75;
                    break;
                default:
                    juniorsTax = 20;
                    seniorsTax = 21.5;
                    break;
            }

            double sum = juniors * juniorsTax + seniors * seniorsTax;
            double expense = sum * 0.05;
            double total = sum - expense;

            Console.WriteLine($"{total:f2}");

        }
    }
}
using System;
using System.Runtime.CompilerServices;

namespace MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categorie = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            switch (categorie)
            {
                case "VIP":
                    ticketPrice = 499.99; 
                    break;
                case "Normal":
                    ticketPrice = 249.99;
                    break;
            }

            double transportPrice = 0;
            if (numberOfPeople < 5)
            {
                transportPrice = budget * 0.75;
            }
            else if (numberOfPeople < 10)
            {
                transportPrice = budget * 0.6;
            }
            else if (numberOfPeople < 25)
            {
                transportPrice = budget * 0.5;
            }
            else if (numberOfPeople < 50)
            {
                transportPrice = budget * 0.4;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            double total = ticketPrice * numberOfPeople + transportPrice;

            if (total < budget)
            {
                Console.WriteLine($"Yes! You have {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva.");
            }


        }
    }
}
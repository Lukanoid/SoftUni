using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double pricePerTicket = 0;
            int totalseats = rows * columns;

            if (projection == "Premiere")
            {
                pricePerTicket = 12;
            }
            else if (projection == "Normal")
            {
                pricePerTicket = 7.5;
            }
            else
            {
                pricePerTicket = 5;
            }
            double totalincome = totalseats * pricePerTicket;
            Console.WriteLine("{0:f2} leva", totalincome);
        }
    }
}
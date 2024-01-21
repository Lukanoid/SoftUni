using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            int numberofnights = days - 1;
            double price = 0;
            switch (room)
            {
                case "room for one person":
                    price = 18;
                    break;
                case "apartment":
                    price = 25;
                    break;
                case "president apartment":
                    price = 35;
                    break;
            }
            double totalprice = numberofnights * price;
            if (room == "apartment")
            {
                if (days < 10)
                {
                    totalprice *= 0.7;
                }
                else if (days > 10 && days < 15)
                {
                    totalprice *= 0.65;
                }
                else
                {
                    totalprice *= 0.5;
                }
            }
            else if (room == "president apartment")
            {
                if (days < 10)
                {
                    totalprice *= 0.9;
                }
                else if (days > 10 && days < 15)
                {
                    totalprice *= 0.85;
                }
                else
                {
                    totalprice *= 0.8;
                }
            }
            if (rating == "positive")
            {
                totalprice = totalprice + (totalprice * 0.25);
            }
            else
            {
                totalprice = totalprice - (totalprice * 0.1);
            }
            Console.WriteLine("{0:f2}", totalprice);
        }
    }
}
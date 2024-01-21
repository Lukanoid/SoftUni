using System;

namespace TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxPerKM = 0;

            if (distance <= 20)
            {
                switch (time)
                {
                    case "day":
                        taxPerKM = 0.79;
                        break;
                    case "night":
                        taxPerKM = 0.9;
                        break;
                }
                double totalPrice = distance * taxPerKM;
                Console.WriteLine($"{totalPrice + 0.7:f2}");
            }
            else if (distance <= 100)
            {
                taxPerKM = 0.09;
                double totalPrice = distance * taxPerKM;
                Console.WriteLine($"{totalPrice:f2}");
            }
            else if (distance > 100)
            {
                taxPerKM = 0.06;
                double totalPrice = distance * taxPerKM;
                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double priceforvideocard = videocards * 250;
            double priceforoneprocessor = priceforvideocard * 0.35;
            double priceforoneram = priceforvideocard * 0.1;

            double totalpriceforprocessor = priceforoneprocessor * processors;
            double totalpriceforRam = priceforoneram * ram;
            double totalprice = priceforvideocard + totalpriceforprocessor + totalpriceforRam;

            if (videocards > processors)
            {
                totalprice *= 0.85;
            }

            if (budget >= totalprice)
            {
                Console.WriteLine($"You have {budget - totalprice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - totalprice):f2} leva more!");
            }
        }
    }
}
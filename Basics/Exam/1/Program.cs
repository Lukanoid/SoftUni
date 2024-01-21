using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerPage = double.Parse(Console.ReadLine());
            double pricePerCover = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());
            double designerPrice = double.Parse(Console.ReadLine());
            double percentageDown = double.Parse(Console.ReadLine());

            double sum = (pricePerPage * 899) + (pricePerCover * 2);
            double discount = percentDiscount / 100;
            double discountage = 1 - discount;
            double sumAfterDiscount = sum * discountage;
            sumAfterDiscount += designerPrice;
            double percent = percentageDown / 100;
            double percentage = 1 - percent;
            double totalsum = sumAfterDiscount * percentage;

            Console.WriteLine($"Avtonom should pay {totalsum:f2} BGN.");
        }
    }
}
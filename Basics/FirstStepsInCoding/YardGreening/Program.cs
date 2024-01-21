using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sqmt = double.Parse(Console.ReadLine());

            double price = sqmt * 7.61;
            double discount = price * 0.18;
            double finalprice = price - discount;

            Console.WriteLine($"The final price is: {finalprice} lv.");
            Console.WriteLine($"The discount is {discount} lv.");

        }
    }
}
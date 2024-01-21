using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double requiredmoney = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toys = puzzles + dolls + teddybears + minions + trucks;
            double totalprice = puzzles * 2.6 + dolls * 3 + teddybears * 4.1 + minions * 8.2 + trucks * 2;

            if (toys >= 50)
            {
                totalprice = totalprice * 0.75;
            }
            double rent = totalprice * 0.1;
            double finalsum = totalprice - rent;

            if (finalsum >= requiredmoney)
            {
                double moneyleft = finalsum - requiredmoney;
                Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
            }
            else if (finalsum < requiredmoney)
            {
                double moneyleft = finalsum - requiredmoney;
                Console.WriteLine($"Not enough money! {Math.Abs(moneyleft):f2} lv needed.");
            }
        }
    }
}
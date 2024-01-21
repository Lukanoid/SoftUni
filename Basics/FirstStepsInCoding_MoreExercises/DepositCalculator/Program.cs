using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine()); 
            double percent = double.Parse(Console.ReadLine());

            double interestpercent = percent / 100;
            double interest = deposit * interestpercent;
            double interestpermonth = interest / 12;
            double totalsum = deposit + months * interestpermonth;

            Console.WriteLine(totalsum);




        }
    }
}
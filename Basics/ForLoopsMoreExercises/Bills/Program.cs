using System;

namespace Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double water = months * 20;
            double internet = months * 15;
            double allTaxes = 0;
            double electricityTaxes = 0;
            double otherTaxes = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double other = electricity + 20 + 15 + (electricity + 20 + 15) * 0.2;
                double allexpenses = electricity + water + internet + other;
                //allTaxes += allexpenses;
                electricityTaxes += electricity;
                otherTaxes += other;
            }
            double average = (electricityTaxes + water + internet + otherTaxes) / months;

            Console.WriteLine($"Electricity: {electricityTaxes:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {otherTaxes:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
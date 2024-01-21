using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyRequired = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            int count = 0;
            int spendCounter = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double savedMoney = double.Parse(Console.ReadLine());
                count++;

                if (action == "spend")
                {
                    spendCounter++;
                    moneyOnHand -= savedMoney;
                    if (moneyOnHand < 0)
                    {
                        moneyOnHand = 0;
                    }
                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(count);
                        break;
                    }
                }
                else if(action == "save")
                {
                    spendCounter = 0;
                    moneyOnHand += savedMoney;
                    if(moneyOnHand >= moneyRequired)
                    {
                        Console.WriteLine($"You saved the money for {count} days.");
                        break;
                    }
                }
            }
        }
    }
}
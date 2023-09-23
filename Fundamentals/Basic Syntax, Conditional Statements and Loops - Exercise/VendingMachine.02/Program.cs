using System;

namespace VendingMachine._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoneyIn = 0;

            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins == 0.1)
                    totalMoneyIn += 0.1;
                else if (coins == 0.2)
                    totalMoneyIn += 0.2;
                else if (coins == 0.5) 
                    totalMoneyIn += 0.5;
                else if (coins == 1)
                    totalMoneyIn += 1;
                else if (coins == 2)
                    totalMoneyIn += 2;
                else
                    Console.WriteLine($"Cannot accept {coins}");

                input = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts" )
                {
                    if (totalMoneyIn >= 2)
                    {
                        totalMoneyIn -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if (product == "Water")
                {
                    if (totalMoneyIn >= 0.7)
                    {
                        totalMoneyIn -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if (product == "Crisps")
                {
                    if(totalMoneyIn >= 1.5)
                    {
                        totalMoneyIn -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");

                }
                else if (product == "Soda")
                {
                    if (totalMoneyIn >= 0.8)
                    {
                        totalMoneyIn -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if (product == "Coke")
                {
                    if(totalMoneyIn >= 1)
                    {
                        totalMoneyIn -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoneyIn:F2}");
        }
    }
}
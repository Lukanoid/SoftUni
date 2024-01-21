using System;   

namespace ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredMoney = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int transactionCount = 1;
            double cs = 0;
            double cc = 0;
            int csCount = 0;
            int ccCount = 0;

            while (input != "End")
            {
                double transaction = double.Parse(input);

                if (transactionCount % 2 != 0)
                {
                    if (transaction > 100)
                    {
                        Console.WriteLine($"Error in transaction!");
                        transactionCount++;
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        cs += transaction;
                        csCount++;
                        transactionCount++;
                    }
                }
                else
                {
                    if (transaction < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                        transactionCount++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cc += transaction;
                        ccCount++;
                        transactionCount++;
                    }
                }
                if (cc + cs >= requiredMoney)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (cc + cs >= requiredMoney)
            {
                double averageCs = cs / csCount;
                double averageCc = cc / ccCount;
                Console.WriteLine($"Average CS: {averageCs:f2}");
                Console.WriteLine($"Average CC: {averageCc:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
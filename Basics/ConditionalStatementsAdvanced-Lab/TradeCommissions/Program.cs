using System;

namespace TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percent = 0;

            if (city == "Sofia")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales < 500)
                {
                    percent = 0.05;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales < 1000)
                {
                    percent = 0.07;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales < 10000)
                {
                    percent = 0.08;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales > 10000)
                {
                    percent = 0.12;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
            }
            else if (city == "Varna")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales <= 500)
                {
                    percent = 0.045;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales <= 1000)
                {
                    percent = 0.075;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales < 10000)
                {
                    percent = 0.1;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales > 10000)
                {
                    percent = 0.13;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales < 500)
                {
                    percent = 0.055;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales <= 1000)
                {
                    percent = 0.08;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales < 10000)
                {
                    percent = 0.12;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
                else if (sales > 10000)
                {
                    percent = 0.145;
                    Console.WriteLine("{0:f2}", sales * percent);
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
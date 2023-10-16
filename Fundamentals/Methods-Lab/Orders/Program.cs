/*
coffee – 1.50
   
water – 1.00
   
coke – 1.40
   
snacks – 2.00
*/


using System.Net.Http.Headers;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int .Parse(Console.ReadLine());

            Bill(product, quantity);
        }

        static void Bill(string product, int quantity)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{quantity * 1.5:f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{quantity * 1:f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{quantity * 1.4:f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{quantity * 2:f2}");
            }
        }
    }
}
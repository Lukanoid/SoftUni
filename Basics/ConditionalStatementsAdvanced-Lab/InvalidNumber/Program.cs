using System;

namespace InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isvalid = num >= 100 && num <= 200 || num == 0;

            if (!isvalid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
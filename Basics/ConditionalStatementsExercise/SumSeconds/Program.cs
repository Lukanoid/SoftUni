using System;

namespace SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firsttime = int.Parse(Console.ReadLine());
            int secondtime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());

            int totaltime = firsttime + secondtime + thirdtime;

            int minutes = totaltime / 60;
            int seconds = totaltime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
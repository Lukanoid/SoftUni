using System;

namespace SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restdays = int.Parse(Console.ReadLine());

            int workingdays = 365 - restdays;
            int minutesplaying = (restdays * 127) + (workingdays * 63);
            int tomcapacity = 30000;

            if (minutesplaying < tomcapacity)
            {
                int diff = tomcapacity - minutesplaying;
                int hours = diff / 60;
                int minutes = diff % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play ");
            }
            else
            {
                int diff = Math.Abs(tomcapacity - minutesplaying);
                int hours = diff / 60;
                int minutes = diff % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
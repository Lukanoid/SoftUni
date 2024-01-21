using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tvseries = Console.ReadLine();
            int timeforoneepisode = int.Parse(Console.ReadLine());
            int timeforbreak = int.Parse(Console.ReadLine());

            double timeforlunch = timeforbreak * 0.125;
            double timeforrelax = timeforbreak * 0.25;
            double timeleft = timeforbreak - timeforrelax - timeforlunch;

            if (timeleft >= timeforoneepisode)
            {
                Console.WriteLine($"You have enough time to watch {tvseries} and left with {Math.Ceiling(timeleft - timeforoneepisode)} minutes free time.");
            }
            else
            {
                double diff = Math.Abs(timeleft - timeforoneepisode);
                Console.WriteLine($"You don't have enough time to watch {tvseries}, you need {Math.Ceiling(diff)} more minutes.");
            }
        }
    }
}
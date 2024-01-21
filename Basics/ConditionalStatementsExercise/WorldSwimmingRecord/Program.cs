using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldrecord = double.Parse(Console.ReadLine());
            double distence = double.Parse(Console.ReadLine());
            double timepermerter = double.Parse(Console.ReadLine());

            double recordbyivan = distence * timepermerter;
            double delay = distence / 15;
            recordbyivan += Math.Floor(delay) * 12.5;

            if (recordbyivan < worldrecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordbyivan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldrecord - recordbyivan):f2} seconds slower.");
            }
        }
    }
}
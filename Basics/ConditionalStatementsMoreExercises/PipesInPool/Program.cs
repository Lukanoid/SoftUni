using System;

namespace PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hoursmissing = double.Parse(Console.ReadLine());

            double litersforpipe1 = hoursmissing * pipe1;
            double litersforpipe2 = hoursmissing * pipe2;
            double waterfilled = litersforpipe1 + litersforpipe2;

            if (v < waterfilled)
            {
                double overfilled = waterfilled - v;
                Console.WriteLine($"For {hoursmissing:f2} hours the pool overflows with {overfilled:f2} liters.");
            }
            else
            {
                double percentfilled = (waterfilled / v) * 100;
                double percentforpipe1 = (litersforpipe1 / waterfilled) * 100;
                double percentforpipe2 = (litersforpipe2 / waterfilled) * 100;
                Console.WriteLine($"The pool is {percentfilled:f2}% full. Pipe 1: {percentforpipe1:f2}%. Pipe 2:{percentforpipe2:f2}%.");
            }
        }
    }
}
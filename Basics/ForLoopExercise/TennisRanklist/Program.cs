using System;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournamets = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int points = startingPoints;
            double winCount = 0;

            for (int i = 0; i < numberOfTournamets; i++)
            {
                string tournamentStatus = Console.ReadLine();

                switch (tournamentStatus)
                {
                    case "W":
                        points += 2000;
                        winCount++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                }
            }

            double averagePoints = (points - startingPoints) / numberOfTournamets;
            double percentage = (winCount / numberOfTournamets) * 100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentage:f2}%");
        }
    }
}
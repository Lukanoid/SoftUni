using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double points = pointsFromAcademy;

            for (int i = 0; i < judges; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                int judgeLenght = judgeName.Length;
                points += (judgeLenght * judgePoints) / 2;


                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
            if (points <= 1250.5)
            {
                double diff = 1250.5 - points;
                Console.WriteLine($"Sorry, {actorName} you need {diff:f1} more!");
            }
        }
    }
}
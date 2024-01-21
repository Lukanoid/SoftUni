using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int missingDays = int.Parse(Console.ReadLine());
            int foodLeftKG = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine()) / 1000;

            double totalFoodForDog = foodForDog * missingDays;
            double totalFoodForCat = foodForCat * missingDays;
            double totalFoodForTurtle = foodForTurtle * missingDays;
            double totalFood = totalFoodForDog + totalFoodForCat + totalFoodForTurtle;

            if (foodLeftKG >= totalFood)
            {
                double diff = Math.Floor(foodLeftKG - totalFood);
                Console.WriteLine($"{diff} kilos of food left.");
            }
            else
            {
                double diff = Math.Ceiling(totalFood -  foodLeftKG);
                Console.WriteLine($"{diff} more kilos of food are needed.");
            }
        }
    }
}
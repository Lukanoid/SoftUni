using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumVolume = lenght * width * height;
            double volumeInLiters = aquariumVolume / 1000;
            double percentage = percent * 10 / 1000;
            double waterRequired = volumeInLiters * (1 - percentage);

            Console.WriteLine(waterRequired);
        }
    }
}
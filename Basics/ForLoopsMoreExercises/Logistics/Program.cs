using System;

namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());
            int allLoads = 0;
            double bussesLoaded = 0;
            double trucksLoaded = 0;
            double trainsLoaded = 0;

            for (int i = 0; i < numberOfLoads; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                allLoads += tons;

                if (tons < 4 )
                {
                    bussesLoaded += tons;
                }
                else if (tons < 12)
                {
                    trucksLoaded += tons;
                }
                else
                {
                    trainsLoaded += tons; 
                }
            }
            double averagePrice = (bussesLoaded * 200 + trucksLoaded * 175 + trainsLoaded * 120) / allLoads;
            double averagePerBus = (bussesLoaded / allLoads * 100);
            double averagePerTruck = (trucksLoaded / allLoads * 100);
            double averagePerTrain = (trainsLoaded / allLoads * 100);
            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{averagePerBus:f2}%");
            Console.WriteLine($"{averagePerTruck:f2}%");
            Console.WriteLine($"{averagePerTrain:f2}%");
        }
    }
}
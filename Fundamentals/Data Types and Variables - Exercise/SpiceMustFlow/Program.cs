namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long startingYield = long.Parse(Console.ReadLine());
            long dayCounter = 0;
            long workersConsumption = 26;
            long totalSpiceExtracted = 0;

            while (true)
            {
                
                if (startingYield < 100)
                {
                    break;
                }               
                totalSpiceExtracted += startingYield - workersConsumption;
                dayCounter++;
                startingYield -= 10;
            }
            if (totalSpiceExtracted >= 26)
            {
                totalSpiceExtracted-= 26;
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(totalSpiceExtracted);
        }
    }
}
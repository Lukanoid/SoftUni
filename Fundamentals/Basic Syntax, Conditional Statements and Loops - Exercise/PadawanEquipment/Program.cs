namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pricePerLightsaber = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());

            double priceForAllLightsabers = Math.Ceiling(students * 1.1) * pricePerLightsaber;
            double priceForAllRobes = students * pricePerRobe;

            int freeBelts = students / 6; 

            double priceForAllBelts = (students - freeBelts) * pricePerBelt;

            double totalmoney = priceForAllLightsabers + priceForAllRobes + priceForAllBelts;

            if(amountOfMoney >= totalmoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalmoney:f2}lv.");
            }
            else
            {
                double neededMoney = totalmoney - amountOfMoney;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
        }
    }
}
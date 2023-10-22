namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pricePerFlour = double.Parse(Console.ReadLine());
            double pricePerEgg = double.Parse(Console.ReadLine());
            double pricePerApron = double.Parse(Console.ReadLine());

            double allAprons = pricePerApron * (students + Math.Ceiling(students * 0.2));
            int freePackages = 0;

            int students2 = students;
            while (students2 > 0)
            {
                if (students2 % 5 == 0)
                {
                    freePackages++;
                }

                students2--;
            }

            double allFlour = pricePerFlour * (students - freePackages);
            double allEggs = pricePerEgg * 10 * students;

            double allExpenses = allAprons + allFlour + allEggs;

            if (budget >= allExpenses)
            {
                Console.WriteLine($"Items purchased for {allExpenses:f2}$.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(budget - allExpenses):f2}$ more needed.");
            }
        }
    }
}
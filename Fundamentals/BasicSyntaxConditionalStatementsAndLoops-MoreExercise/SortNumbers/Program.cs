namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            List<int> allNumbers = new List<int>();
            allNumbers.Add(firstNum);
            allNumbers.Add(secondNum);
            allNumbers.Add(thirdNum);

            foreach (var allNumber in allNumbers.OrderByDescending(x=> x))
            {
                Console.WriteLine(allNumber);
            }
        }
    }
}

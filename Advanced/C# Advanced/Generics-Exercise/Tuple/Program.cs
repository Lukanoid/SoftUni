using System.Data;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] drinkTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] numbersTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string, string> personTuple =
                new CustomTuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2],
                    string.Join(" ", personTokens[3..]));

            CustomTuple<string, int, bool> drinkTuple =
                new CustomTuple<string, int, bool>(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

            CustomTuple<string, double, string> numbersTuple =
                new CustomTuple<string, double, string>(numbersTokens[0], double.Parse(numbersTokens[1]),
                    numbersTokens[2]);

            Console.WriteLine(personTuple.ToString());
            Console.WriteLine(drinkTuple.ToString());
            Console.WriteLine(numbersTuple.ToString());
        }
    }
}

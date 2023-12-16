namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string currentGame = Console.ReadLine();

            Dictionary<string, double> gameAndPrice = new Dictionary<string, double>();
            gameAndPrice.Add("OutFall 4", 39.99);
            gameAndPrice.Add("CS: OG", 15.99);
            gameAndPrice.Add("Zplinter Zell", 19.99);
            gameAndPrice.Add("Honored 2", 59.99);
            gameAndPrice.Add("RoverWatch", 29.99);
            gameAndPrice.Add("RoverWatch Origins Edition", 39.99);

            double totalSpent = 0;
            while (currentGame != "Game Time")
            {
                if (!gameAndPrice.ContainsKey(currentGame))
                {
                    Console.WriteLine("Not Found");
                }
                else if (gameAndPrice.ContainsKey(currentGame))
                {
                    if (gameAndPrice[currentGame] > balance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= gameAndPrice[currentGame];
                        totalSpent += gameAndPrice[currentGame];
                        Console.WriteLine($"Bought {currentGame}");
                    }
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }


                currentGame = Console.ReadLine();
            }

            if (balance != 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}

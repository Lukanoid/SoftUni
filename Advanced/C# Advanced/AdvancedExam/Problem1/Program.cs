namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> amountOfMoney = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> priceOfFoods = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int foodAte = 0;
            int moneyIndex = amountOfMoney.Count - 1;
            int priceIndex = 0;

            while (amountOfMoney.Any() && priceOfFoods.Any())
            {
                int money = amountOfMoney[moneyIndex];
                int price = priceOfFoods[priceIndex];
                if (money == price)
                {
                    foodAte++;
                    amountOfMoney.RemoveAt(moneyIndex);
                    priceOfFoods.RemoveAt(priceIndex);
                }
                else if (money > price)
                {
                    foodAte++;
                    int change = money - price;
                    amountOfMoney.RemoveAt(moneyIndex);
                    priceOfFoods.RemoveAt(priceIndex);
                    if (amountOfMoney.Any())
                    {
                        amountOfMoney[moneyIndex - 1] += change;
                    }
                }
                else
                {
                    amountOfMoney.RemoveAt(moneyIndex);
                    priceOfFoods.RemoveAt(priceIndex);
                }

                moneyIndex--;
            }

            if (foodAte >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodAte} foods.");
            }
            else if (foodAte > 0)
            {
                if (foodAte == 1)
                {
                    Console.WriteLine($"Henry ate: {foodAte} food.");
                }
                else
                {
                    Console.WriteLine($"Henry ate: {foodAte} foods.");
                }
            }
            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}

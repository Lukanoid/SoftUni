using BorderControl.Core.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;

namespace BorderControl.Core;

public class Engine : IEngine
{
    public void Run()
    {
        int n = int.Parse(Console.ReadLine());
        List<IBuyer> buyers = new List<IBuyer>();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            if (tokens.Length == 4)
            {
                string id = tokens[2];
                string birthDate = tokens[3];

                IBuyer currentCitizen = new Citizens(id, name, age, birthDate);
                buyers.Add(currentCitizen);
            }
            else
            {
                string group = tokens[2];
                IBuyer currentRebel = new Rebel(name, age, group);
                buyers.Add(currentRebel);
            }
        }

        string currentBuyer;
        while ((currentBuyer = Console.ReadLine()) != "End")
        {
            foreach (var buyer in buyers)
            {
                if (buyer.Name == currentBuyer)
                {
                    buyer.BuyFood();
                }
            }
        }

        Console.WriteLine(buyers.Sum(x=> x.Food));

    }
}
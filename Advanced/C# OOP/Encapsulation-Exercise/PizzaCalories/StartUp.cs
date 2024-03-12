using System.Globalization;
using PizzaCalories.Models;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaData = Console.ReadLine().Split(" ");
                string[] doughData = Console.ReadLine().Split(" ");

                Dough dough = new Dough(doughData[1], doughData[2], double.Parse(doughData[3]));

                Pizza pizza = new Pizza(pizzaData[1], dough);

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }

                    string[] toppingData = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(toppingData[1], double.Parse(toppingData[2]));
                    pizza.AddIngredient(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

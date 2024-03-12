using System.Runtime.InteropServices;

namespace PizzaCalories.Models;

public class Topping
{
    private const double baseCaloriesPerGram = 2;

    private string type;
    private double grams;
    private Dictionary<string, double> typeModifiers;

    public Topping(string type, double grams)
    {
        typeModifiers = new Dictionary<string, double>
        {
            {"meat", 1.2},
            {"veggies" , 0.8},
            {"cheese", 1.1}, 
            {"sauce" , 0.9}
        };

        Type = type;
        Grams = grams;
    }

    public string Type
    {
        get => type;

        private set
        {
            if (!typeModifiers.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            type = value;
        }
    }
    public double Grams 
    {
        get => grams;

        private set
        {
            if (value < 0 || value > 50)
            {
                throw new ArgumentException($"{Type} weight should be in the range [1..50].");
            }
            grams = value;
        }

    }

    public double Calories
    {
        get
        {
            double modifier = typeModifiers[Type.ToLower()];
            return baseCaloriesPerGram * Grams * modifier;
        }
    }
}
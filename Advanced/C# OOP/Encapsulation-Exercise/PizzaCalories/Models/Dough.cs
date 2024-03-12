namespace PizzaCalories.Models;

public class Dough
{
    private const double baseCaloriesPerGram = 2;

    private double grams;
    private string type;
    private string technique;
    private Dictionary<string, double> bakingTechnique;
    private Dictionary<string, double> flourType;

    public Dough(string type, string technique, double grams)
    {
        bakingTechnique = new Dictionary<string, double> { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };
        flourType = new Dictionary<string, double> { { "white", 1.5 }, { "wholegrain", 1 } };

        Type = type;
        Technique = technique;
        Grams = grams;
    }

    public double Grams
    {
        get => grams;

        private set
        {
            if (value < 0 || value > 200)
            {
                throw new Exception("Dough weight should be in the range [1..200].");
            }
            grams = value;
        }
    }

    public string Type
    {
        get => type;

        private set
        {
            if (!flourType.ContainsKey(value.ToLower()))
            {
                throw new Exception("Invalid type of dough.");
            }

            type = value;
        }
    }

    public string Technique
    {
        get => technique;
        private set
        {
            if (!bakingTechnique.ContainsKey(value.ToLower()))
            {
                throw new Exception("Invalid type of dough.");
            }

            technique = value;
        }
    }

    public double Calories
    {
        get
        {
            double flourTypeModifier = flourType[Type.ToLower()];

            double techniqueModifier = bakingTechnique[Technique.ToLower()];

            return baseCaloriesPerGram * Grams * flourTypeModifier * techniqueModifier;
        }
    }

}
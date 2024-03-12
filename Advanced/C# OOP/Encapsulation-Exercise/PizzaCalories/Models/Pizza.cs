namespace PizzaCalories.Models;

public class Pizza
{
    private string name;
    private List<Topping> toppings;

    public Pizza(string name, Dough dough)
    {
        toppings = new List<Topping>();

        Name = name;
        Dough = dough;
    }

    public string Name
    {
        get => name;
        private set
        {

            if (value.Length < 1 || value.Length > 15)
            {
                throw new Exception("Pizza name should be between 1 and 15 symbols.");
            }


            name = value;
        }
    }

    private IReadOnlyCollection<Topping> Toppings
    {
        get => toppings.AsReadOnly();

    }
    public Dough Dough { get; set; }

    public double Calories
    {
        get
        {
            double totalCalories = default;

            foreach (var topping in Toppings)
            {
                totalCalories += topping.Calories;
            }

            totalCalories += Dough.Calories;

            return totalCalories;
        }
    }

    public void AddIngredient(Topping topping)
    {
        if (Toppings.Count == 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }

        toppings.Add(topping);
    }

    public override string ToString()
    {
        return $"{Name} - {this.Calories:f2} Calories.";
    }
}
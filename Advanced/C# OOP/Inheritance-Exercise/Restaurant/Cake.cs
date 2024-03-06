namespace Restaurant;

public class Cake : Dessert
{
    private const double DessertGrams = 250;
    private const double DesertCalories = 1000;
    private const decimal CakePrice = 5m;

    public Cake(string name) 
        : base(name, CakePrice, DessertGrams, DesertCalories)
    {
    }
}
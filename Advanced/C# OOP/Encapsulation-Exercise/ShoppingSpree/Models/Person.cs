namespace ShoppingSpree.Models;

public class Person
{
    private string name;
    private decimal money;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Bag = new List<Product>();
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name cannot be empty");
            }

            name = value;
        }
    }

    public decimal Money
    {
        get
        {
            return money;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Money cannot be negative");
            }
            money = value;
        }
    }

    private List<Product> Bag { get; set; }


    public override string ToString()
    {
        string productsString = Bag.Any()
            ? string.Join(", ", Bag.Select(p => p.Name))
            : "Nothing bought";

        return $"{Name} - {productsString}";
    }

    public string Add(Product product)
    {
        if (Money >= product.Cost)
        {
            Bag.Add(product);
            Money -= product.Cost;
            return $"{Name} bought {product.Name}";
        }
        else
        {
            return $"{Name} can't afford {product.Name}";
        }
    }

}
namespace Animals;

public class Kitten : Cat
{
    private const string Gender = "Female";
    private const string Sound = "Meow";
    public Kitten(string name, int age) 
        : base(name, age, Gender)
    {
    }

    public override string ProduceSound() => Sound;
    
}
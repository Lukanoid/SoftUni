namespace Animals;

public class Tomcat : Cat
{
    private const string Gender = "Male";
    private const string Sound = "MEOW";
    public Tomcat(string name, int age) 
        : base(name, age, Gender)
    {
    }

    public override string ProduceSound() => Sound;
    
}
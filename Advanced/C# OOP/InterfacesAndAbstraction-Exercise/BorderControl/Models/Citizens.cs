using BorderControl.Models.Interfaces;

namespace BorderControl.Models;

public class Citizens : IIdentifiable, INameable, IBirthdate, IBuyer
{
    public Citizens(string id, string name, int age, string birthDate)
    {
        Id = id;
        Name = name;
        Age = age;
        BirthDate = birthDate;
    }
    public string Id { get;}
    public int Age { get; set; }
    public string Name { get; }
    public string BirthDate { get; }
    public int Food { get; set; }
    public void BuyFood()
    {
        Food += 10;
    }
}
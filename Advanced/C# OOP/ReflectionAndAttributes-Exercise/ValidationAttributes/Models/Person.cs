using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models;

public class Person
{

    public Person(string fullName, int age)
    {
        this.fullName = fullName;
        this.age = age;
    }

    [MyRequired]
    public string fullName { get; private set; }

    [MyRange(12, 90)]
    public int age { get; private set; }
}
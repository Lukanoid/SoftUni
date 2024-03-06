using System.Text;

namespace Person;

public class Person
{
	private int age;
    private string name;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public virtual int Age
	{
        get
        {
            return age;
        }
        set
        {
            if (value > 0)
            {
                age = value;
            }
        }
	}

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"Name: {Name}, Age: {Age}");

        return sb.ToString().TrimEnd();
    }
}
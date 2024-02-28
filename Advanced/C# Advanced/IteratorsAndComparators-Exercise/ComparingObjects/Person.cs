namespace ComparingObjects;

public class Person : IComparable<Person>
{
	private string name;
    private int age;
    private string town;

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
	public int Age
	{
        get
        {
            return age;;
        }
        set
        {
            age = value;
        }
	}
    public string Town
    {
        get
        {
            return town;
        }
        set
        {
            town = value;
        }
    }

    public int CompareTo(Person? other)
    {
        if (this.Name.CompareTo(other.Name) != 0)
        {
            return this.Name.CompareTo(other.Name);
        }

        if (this.Age.CompareTo(other.Age) != 0)
        {
            return this.Age.CompareTo(other.Age);
        }

        return this.Town.CompareTo(other.Town);
    }
}
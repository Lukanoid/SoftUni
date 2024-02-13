namespace DefiningClasses;

public  class Family
{
	private  List<Person> people = new List<Person>();

	public  List<Person> People
	{
        get
        {
            return this.people;
        }
        set
        {
            this.people = value;
        }
	}

    public void AddMember(Person person)
    {
        People.Add(person);
    }

    public Person GetOldestMember()
    {
        List<Person> sorted = this.People.OrderByDescending(p => p.Age).ToList();

        return sorted.FirstOrDefault();
    }
}
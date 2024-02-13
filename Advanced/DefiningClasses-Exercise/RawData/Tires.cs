namespace RawData;

public class Tires
{
	private int age;
    private double pressure;

    public Tires(double pressure, int age)
    {
        this.pressure = pressure;
        this.age = age;
    }
    public int Age
	{
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
	}

	public double Pressure
	{
        get
        {
            return this.pressure;
        }
        set
        {
            this.pressure = value;
        }
	}

}
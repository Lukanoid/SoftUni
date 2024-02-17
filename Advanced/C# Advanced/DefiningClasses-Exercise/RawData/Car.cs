namespace RawData;

public class Car
{
	private string model;
	private Engine engine;
    private Cargo cargo;
    private Tires[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = tires;
    }
	public string Model
	{
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
	}

    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = value;
        }
    }

    public Cargo Cargo
    {
        get
        {
            return this.cargo;
        }
        set
        {
            this.cargo = value;
        }
    }

    public Tires[] Tires
    {
        get
        {
            return this.tires;
        }
        set
        {
            this.tires = value;
        }
    }

}
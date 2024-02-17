namespace PokemonTrainer;

public class Trainer
{
	private string name;
    private int numberOfBadges;
    List<Pokemon> pokemonList = new List<Pokemon>();

    public Trainer()
    {
        numberOfBadges = 0;
    }
	public string  Name
	{
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
	}

    public int NumberOfBadges
    {
        get
        {
            return this.numberOfBadges;
        }
        set
        {
            this.numberOfBadges = value;
        }
    }

    public List<Pokemon> PokemonList
    {
        get {
            return this.pokemonList;
        }
        set {
            this.pokemonList = value;
        }
    }



}
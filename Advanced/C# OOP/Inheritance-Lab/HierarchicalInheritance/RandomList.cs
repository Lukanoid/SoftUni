namespace CustomRandomList;

public class RandomList : List<string>
{
    public string RandomString()
    {
        Random random = new Random();

        int indexToRemove = random.Next(base.Count);

        string item = base[indexToRemove];

        base.RemoveAt(indexToRemove);
        
        return item;
    }
}
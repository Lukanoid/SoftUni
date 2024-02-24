using System.Text;

namespace GenericBoxOfString;

public class Box<T>
{
	private List<T> items;

    public Box()
    {
        items = new List<T>();
    }

	public List<T> Items
	{
        get
        {
            return items;
        }
        set
        {
            items = value;
        }
	}

    public void Add(T item)
    {
        Items.Add(item);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in Items)
        {
            sb.AppendLine($"{typeof(T)}: {item.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}
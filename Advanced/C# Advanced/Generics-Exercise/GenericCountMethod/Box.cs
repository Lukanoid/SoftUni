using System.Text;

namespace GenericBoxOfString;

public class Box<T> where T : IComparable<T>
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

    public int Count(T itemComparer)
    {
        int count  = 0;
        foreach (T item in Items)
        {
            if (item.CompareTo(itemComparer) > 0)
            {
                count++;
            }
        }

        return count;
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
using System.Collections;
using System.Threading.Channels;

namespace ListyIterator;

public class CustomListyIterator<T> : IEnumerable<T>
{
    private List<T> _list = new List<T>();
    private int index = 0;

    public CustomListyIterator(List<T> list)
    {
        _list = list;
    }

    public bool Move()
    {
        if (index < _list.Count - 1)
        {
            index++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        if (index + 1 == _list.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Print()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(_list[index]);
        }
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _list.Count; i++)
        {
            yield return _list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
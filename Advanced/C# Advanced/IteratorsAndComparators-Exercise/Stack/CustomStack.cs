using System.Collections;

namespace Stack;

public class CustomStack<T> : IEnumerable<T>
{
    private List<T> numbers = new List<T>();

    public CustomStack(List<T> numbers)
    {
        this.numbers = numbers;
    }

    public int Count { get => numbers.Count;  }

    public void Push(T item)
    {
        numbers.Add(item);
    }

    public T Pop()
    {
        if (numbers.Count == 0)
        {
            
            throw new InvalidOperationException("No elements");
        }

        T removedItem = numbers[numbers.Count - 1];
        numbers.RemoveAt(numbers.Count - 1);

        return removedItem;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            yield return numbers[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
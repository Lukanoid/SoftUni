using System.Runtime.InteropServices.ComTypes;

namespace CustomStack;

public class StackOfStrings : Stack<string>
{
    public bool IsEmpty()
    {
        if (this.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddRange(IEnumerable<string> collection)
    {
        foreach (var item in collection)
        {
            this.Push(item);
        }
    }
}
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Demo;

public class UniversityEnumerator : IEnumerator<string>
{
    private string[] students;
    int index = -1;

    public UniversityEnumerator(string[] students)
    {
        this.students = students;
    }

    public bool MoveNext()
    {
        return ++index < students.Length;
    }

    public void Reset()
    {
        index = -1;
    }

    public string Current
    {
        get => students[index];
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        Reset();
    }
}
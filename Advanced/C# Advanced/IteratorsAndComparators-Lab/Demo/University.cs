using System.Collections;

namespace Demo;

public class University : IEnumerable<string>
{
    private string[] students;
    public University(string[] students)
    {
        this.students = students;
    }
    public IEnumerator<string> GetEnumerator()
    {
        return new UniversityEnumerator(students);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

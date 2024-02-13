namespace DateModifier;

public class DateModifier
{
    public int DateCalculation(string firstDate, string secondDate)
    {
        int diff = 0;
        string[] dateOne = firstDate.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] dateTwo = secondDate.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        DateTime date1 = new DateTime(int.Parse(dateOne[0]), int.Parse(dateOne[1]), int.Parse(dateOne[2]));
        DateTime date2 = new DateTime(int.Parse(dateTwo[0]), int.Parse(dateTwo[1]), int.Parse(dateTwo[2]));

        TimeSpan difference = date2.Subtract(date1);

        diff = difference.Days;
        return diff;
    }
}
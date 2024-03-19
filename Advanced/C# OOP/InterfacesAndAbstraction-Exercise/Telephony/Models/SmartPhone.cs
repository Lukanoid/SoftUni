using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class SmartPhone : ICallable, IBrowsable
{
    public void Call(string number)
    {
        Console.WriteLine($"Calling... {number}");
    }

    public void Browse(string URL)
    {
        Console.WriteLine($"Browsing: {URL}!");
    }
}
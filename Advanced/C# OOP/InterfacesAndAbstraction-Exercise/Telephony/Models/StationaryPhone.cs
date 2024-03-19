using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class StationaryPhone : ICallable
{
    public void Call(string number)
    {
        Console.WriteLine($"Dialing... {number}");
    }
}
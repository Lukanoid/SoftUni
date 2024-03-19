using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            StationaryPhone stationaryPhone = new StationaryPhone();
            SmartPhone smartPhone = new SmartPhone();

            foreach (var phonenumber in phoneNumbers)
            {
                if (phonenumber.All(char.IsDigit))
                {
                    if (phonenumber.Length == 7)
                    {
                        stationaryPhone.Call(phonenumber);
                    }
                    else
                    {
                        smartPhone.Call(phonenumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var website in websites)
            {
                if (website.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartPhone.Browse(website);
                }
            }
        }
    }
}

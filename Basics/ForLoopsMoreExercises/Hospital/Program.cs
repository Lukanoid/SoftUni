using System;
using System.Xml;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatiens = 0;
            int untreatedPatiens = 0;
            int daysCount = 0;

            for (int i = 1; i <= days; i++)
            {
                daysCount ++;
                int patiens = int.Parse(Console.ReadLine());
                if (daysCount == 3)
                {
                    if (untreatedPatiens > treatedPatiens)
                    {
                        doctors++;
                    }
                    daysCount = 0;
                }
                if (patiens <= doctors)
                {
                    treatedPatiens += patiens;
                }
                else
                {
                    untreatedPatiens += patiens - doctors;
                    treatedPatiens += doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatiens}.");
            Console.WriteLine($"Untreated patients: {untreatedPatiens}.");
        }
    }
}
using System; 

namespace Day_Of_The_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string dayname;
            switch (day)
            {
                case 1:
                    dayname = "Monday";
                    break;
                case 2:
                    dayname = "Tuesday";
                        break;
                case 3:
                    dayname = "Wednesday";
                    break;
                case 4:
                    dayname = "Thursday";
                    break;
                case 5:
                    dayname = "Friday";
                    break;
                case 6:
                    dayname = "Saturday";
                    break;
                case 7:
                    dayname = "Sunday";
                    break;
                default:
                    dayname = "Error";
                    break;
            }
            Console.WriteLine(dayname);
        }

    }
}
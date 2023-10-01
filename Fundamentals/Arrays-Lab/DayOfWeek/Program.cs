namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] day = new string [7];
            day[0] = "Monday";
            day[1] = "Tuesday";
            day[2] = "Wednesday";
            day[3] = "Thursday";
            day[4] = "Friday";
            day[5] = "Saturday";
            day[6] = "Sunday";
            switch (n)
            {
                case 1:
                    Console.WriteLine(day[0]);
                    break;
                case 2:
                    Console.WriteLine(day[1]);
                    break;
                case 3:
                    Console.WriteLine(day[2]);
                    break;
                case 4:
                    Console.WriteLine(day[3]);
                    break;
                case 5:
                    Console.WriteLine(day[4]);
                    break;
                case 6:
                    Console.WriteLine(day[5]);
                    break;
                case 7:
                    Console.WriteLine(day[6]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

        }
    }
}
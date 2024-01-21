using System;

namespace VacationBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesperhour = int.Parse(Console.ReadLine());
            int daysforbook = int.Parse(Console.ReadLine());

            int timeforonebook = pages / pagesperhour;
            int requiredhours = timeforonebook / daysforbook;

            Console.WriteLine(requiredhours);
        }
    }
}
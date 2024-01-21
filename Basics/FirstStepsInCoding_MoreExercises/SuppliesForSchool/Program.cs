using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double marPrice = 7.20;
            double detPrice = 1.20;

            double priceForPens = pens * penPrice;
            double priceForMarkers = markers * marPrice;
            double priceForDetergent = detergent * detPrice;
            double totalsum = priceForPens + priceForMarkers + priceForDetergent;
            double finalsum = totalsum - (totalsum * percent / 100);

            Console.WriteLine(finalsum);

        }
    }
}
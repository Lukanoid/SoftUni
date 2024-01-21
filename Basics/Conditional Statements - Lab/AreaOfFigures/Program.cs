using System;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double square = double.Parse(Console.ReadLine());
                double result = square * square;
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "rectangle")
            {
                double sidea = double.Parse(Console.ReadLine());
                double sideb = double.Parse(Console.ReadLine());
                double rectanglearea = sidea * sideb;
                Console.WriteLine($"{rectanglearea:f3}");
            } 
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circlearea = Math.PI * (radius * radius);
                Console.WriteLine($"{circlearea:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse( Console.ReadLine());
                double b = double.Parse( Console.ReadLine());
                double trainglearea = a * b / 2;
                Console.WriteLine($"{trainglearea:f3}");
            }
        }
    }
}
using System;

namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string boundaries = "";

            if (age <= 2)
            {
                boundaries = "baby";
            }
            else if (age <= 13)
            {
                boundaries = "child";
            }
            else if (age <= 19)
            {
                boundaries = "teenager";
            }
            else if (age <= 65)
            {
                boundaries = "adult";
            }
            else
            {
                boundaries = "elder";
            }
            Console.WriteLine(boundaries);
        }
    }
}
using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string sex = Console.ReadLine();
            int lifeExpectancy = 0;

            if (type == "British Shorthair")
            {
                lifeExpectancy = 13;
                if (sex == "f")
                {
                    lifeExpectancy++;
                }
            }
            else if (type == "Siamese")
            {
                lifeExpectancy = 15;
                if(sex == "f")
                {
                    lifeExpectancy++;
                }
            }
            else if(type == "Persian")
            {
                lifeExpectancy = 14;
                if (sex == "f")
                {
                    lifeExpectancy++;
                }
            }
            else if (type == "Ragdoll")
            {
                lifeExpectancy = 16;
                if (sex == "f")
                {
                    lifeExpectancy++;
                }
            }
            else if (type == "American Shorthair")
            {
                lifeExpectancy = 12;
                if (sex == "f")
                {
                    lifeExpectancy++;
                }
            }
            else if (type == "Siberian")
            {
                lifeExpectancy = 11;
                if (sex == "f")
                {
                    lifeExpectancy++;
                }
            }
            else
            {
                Console.WriteLine($"{type} is invalid cat!");
            }
            int months = lifeExpectancy * 12;
            int catmonths = months / 6;
            switch (type)
            {
                case "British Shorthair":
                case "Siamese":
                case "Persian":
                case "Ragdoll":
                case "American Shorthair":
                case "Siberian":
                    Console.WriteLine($"{catmonths} cat months");
                    break;
            }


        }
    }
}
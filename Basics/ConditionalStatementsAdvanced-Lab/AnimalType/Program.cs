using System;

namespace AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animnal = Console.ReadLine();

            switch (animnal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
﻿namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            if (age < 15)
            {
                Person person = new(name, age);
                Console.WriteLine(person);
            }
            else
            {
                Child child = new Child(name, age);

                Console.WriteLine(child);
            }

        }
    }
}
using System;

namespace OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int count = 0;
            bool isBookFound = false;
            string nextBook = Console.ReadLine();

            while (nextBook != "No More Books")
            {
                if (nextBook == bookName)
                {
                    isBookFound = true;
                    break;
                }
                count++;
                nextBook = Console.ReadLine();                
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
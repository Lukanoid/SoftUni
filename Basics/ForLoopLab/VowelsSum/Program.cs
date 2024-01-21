using System;

namespace VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int textlenght = text.Length;
            int value = 0;

            for (int i = 0; i < textlenght; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        value += 1;
                        break;
                    case 'e':
                        value += 2;
                        break;
                    case 'i':
                        value += 3;
                        break;
                    case 'o':
                        value += 4;
                        break;
                    case 'u':
                        value += 5;
                        break;
                }
            }
            Console.WriteLine(value);

        }
    }
}
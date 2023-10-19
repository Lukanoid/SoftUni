using System.Runtime.ExceptionServices;

namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            GetCharsInBetween(start, end);
        }

        static void GetCharsInBetween(char start, char end)
        {
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }


        }
    }
}
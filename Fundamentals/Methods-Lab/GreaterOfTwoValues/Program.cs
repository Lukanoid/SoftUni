using System.Net;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int greaterValue = GetMax(a, b);

                Console.WriteLine(greaterValue);
            }
            else if (input == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                char greaterValue = GetMax(a, b);

                Console.WriteLine(greaterValue);
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string greaterValue = GetMax(a, b);

                Console.WriteLine(greaterValue);
            }
        }

        static int GetMax(int a, int b)
        {
            int result = Math.Max(a, b);

            return result;
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        static string GetMax(string a, string b)
        {
            int result = string.Compare(a, b);

            if (result == 1)
            {
                return a;
            }
            else if (result == -1)
            {
                return b;
            }
            return a;
        }
    }
}
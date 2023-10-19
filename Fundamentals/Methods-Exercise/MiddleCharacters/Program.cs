namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(input));
        }

        static string MiddleCharacter(string input)
        {
            if (input.Length % 2 != 0)
            {
                char[] arr = new char[input.Length];
                arr = input.ToCharArray();

                int middleChar = arr.Length / 2;

                char midChar = arr[middleChar];
                return midChar.ToString();
            }
            else
            {
                char[] arr = new char[input.Length];
                arr = input.ToCharArray();

                int middleChar = arr.Length / 2;

                string bothChars = arr[middleChar - 1] + arr[middleChar].ToString();

                return bothChars;
            }

        }
    }
}
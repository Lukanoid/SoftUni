namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string output = CombinedString(input, number);
            Console.WriteLine(output);
        }

        static string CombinedString(string input, int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
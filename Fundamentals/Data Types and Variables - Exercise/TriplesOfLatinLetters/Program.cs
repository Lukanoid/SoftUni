namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetter = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLetter; i++)
            {
                for (int j = 0; j < numberOfLetter; j++)
                {
                    for (int k = 0; k < numberOfLetter; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
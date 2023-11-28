namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] data = input.ToCharArray();
            List<char> newList = new List<char>();

            for (int i = 0; i < data.Length; i++)
            {
                int currentSymbol = data[i] + 3;
                newList.Add((char)currentSymbol);
            }

            Console.WriteLine(string.Join("",newList));
        }
    }
}
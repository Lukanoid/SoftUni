namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
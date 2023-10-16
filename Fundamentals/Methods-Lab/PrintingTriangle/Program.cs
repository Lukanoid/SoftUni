namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTriangle(1, input);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void PrintTriangle(int start, int end)
        {
            for (int i = 1; i <= end; i++)
            {
                PrintLine(1, i);
            }

            for (int i = end - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
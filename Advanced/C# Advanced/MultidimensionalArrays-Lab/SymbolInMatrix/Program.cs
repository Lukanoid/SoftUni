namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] rowArray = Console.ReadLine().ToCharArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowArray[cols];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isSymbolFound = false; 

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == symbol)
                    {
                        isSymbolFound = true;
                        Console.WriteLine($"({rows}, {cols})");
                        break;
                    }
                }

                if (isSymbolFound)
                {
                    break;
                }
            }

            if (!isSymbolFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }

    }
}

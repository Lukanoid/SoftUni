namespace SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];
            int count = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] rowArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowArray[cols];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    string currentSymbol = matrix[rows, cols];

                    if (currentSymbol == matrix[rows, cols + 1] && currentSymbol == matrix[rows + 1, cols] &&
                        currentSymbol == matrix[rows + 1, cols + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

    }
}

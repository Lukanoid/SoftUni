namespace SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(size[0], size[1], ", ");

            int maxValue = matrix[0, 0];
            int maxSquareRow = 0;
            int maxSquareColumn = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    int squareSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] +
                                    matrix[rows + 1, cols + 1];
                    if (squareSum > maxValue)
                    {
                        maxSquareRow = rows;
                        maxSquareColumn = cols;
                        maxValue = squareSum;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow, maxSquareColumn]} {matrix[maxSquareRow, maxSquareColumn + 1]}");
            Console.WriteLine($"{matrix[maxSquareRow + 1, maxSquareColumn]} {matrix[maxSquareRow + 1, maxSquareColumn + 1]}");
            Console.WriteLine(maxValue);

        }

        public static int[,] ReadMatrix(int rows, int cols, string separator)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowArray = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            return matrix;
        }
    }
}

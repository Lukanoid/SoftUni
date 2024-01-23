namespace SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(input[0], input[1], " ");

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                int columnSum = 0;  

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    columnSum += matrix[rows, cols];
                }

                Console.WriteLine(columnSum);
            }

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

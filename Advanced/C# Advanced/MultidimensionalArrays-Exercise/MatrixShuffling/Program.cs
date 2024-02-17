namespace MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = rowArray[col];
                }
            }


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                string[] data = command.Split();
                if (data.Length == 5)
                {
                    if (int.Parse(data[1]) < matrix.GetLength(0) && int.Parse(data[2]) < matrix.GetLength(1) && int.Parse(data[3]) <         matrix.GetLength(0) && int.Parse(data[4]) < matrix.GetLength(1) && data[0] == "swap")
                    {
                        string temp = matrix[int.Parse(data[1]), int.Parse(data[2])];
                        matrix[int.Parse(data[1]), int.Parse(data[2])] = matrix[int.Parse(data[3]), int.Parse(data[4])];
                        matrix[int.Parse(data[3]), int.Parse(data[4])] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}

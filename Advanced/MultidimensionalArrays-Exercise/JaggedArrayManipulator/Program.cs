namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] *= 2;
                    }

                    for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                    {
                        jaggedArray[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] /= 2;
                    }

                    for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                    {
                        jaggedArray[row + 1][i] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End" || command.Length != 4)
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (command[0] == "Add")
                {
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else
                {
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

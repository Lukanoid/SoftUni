namespace JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] data = command.Split();

                int row = int.Parse(data[1]);
                int col = int.Parse(data[2]);
                int value = int.Parse(data[3]);

                if (row < 0 || col < 0 || row >= jaggedArray.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (data[0] == "Add")
                {
                    if (jaggedArray[row].Length > col)
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    if (jaggedArray[row].Length > col)
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
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

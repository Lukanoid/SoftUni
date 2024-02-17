namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int[] position = new int[2];
            int enemyCounter = 0;
            int planeHealth = 300;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'J')
                    {
                        position[0] = row;
                        position[1] = col;
                    }
                    else if (input[col] == 'E')
                    {
                        enemyCounter++;
                    }
                }
            }

            int currentRow = position[0];
            int currentCol = position[1];

            while (enemyCounter > 0)
            {
                if (planeHealth <= 0)
                {
                    break;
                }
                string command = Console.ReadLine();
                matrix[currentRow, currentCol] = '-';

                if (command == "down")
                {
                    currentRow++;
                }
                else if (command == "up")
                {
                    currentRow--;
                }
                else if (command == "left")
                {
                    currentCol--;
                }
                else
                {
                    currentCol++;
                }

                if (matrix[currentRow, currentCol] == '-')
                {
                    matrix[currentRow, currentCol] = 'J';
                }
                else if (matrix[currentRow, currentCol] == 'E')
                {
                    matrix[currentRow, currentCol] = 'J';
                    if (enemyCounter > 1)
                    {
                        planeHealth -= 100;
                    }
                    enemyCounter--;
                }
                else if (matrix[currentRow, currentCol] == 'R')
                {
                    planeHealth = 300;
                    matrix[currentRow, currentCol] = 'J';
                }
            }

            if (enemyCounter == 0)
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
            }
            else
            {
                Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{currentRow}, {currentCol}]!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

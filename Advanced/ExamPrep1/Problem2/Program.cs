namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            int[] startingPosition = new int[2];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = input[col];
                    if (input[col] == 'S')
                    {
                        startingPosition[0] = row;
                        startingPosition[1] = col;
                    }

                }
            }

            int currentRow = startingPosition[0];
            int currentCol = startingPosition[1];
            int caught = 0;
            bool shipSank = false;

            string command = Console.ReadLine();

            while (command != "collect the nets")
            {
                field[currentRow, currentCol] = '-';
                if (command == "down")
                {
                    if (currentRow == n - 1)
                    {
                        currentRow = 0;
                    }
                    else
                    {
                        currentRow++;
                    }
                }
                else if (command == "up")
                {
                    if (currentRow == 0)
                    {
                        currentRow = n - 1;
                    }
                    else
                    {
                        currentRow--;
                    }
                }
                else if (command == "right")
                {
                    if (currentCol == n - 1)
                    {
                        currentCol = 0;
                    }
                    else
                    {
                        currentCol++;
                    }
                }
                else if (command == "left")
                {
                    if (currentCol == 0)
                    {
                        currentCol = n - 1;
                    }
                    else
                    {
                        currentCol--;
                    }
                }

                if (field[currentRow, currentCol] == '-')
                {
                    field[currentRow, currentCol] = 'S';
                }
                else if (field[currentRow, currentCol] == 'W')
                {
                    field[currentRow, currentCol] = 'S';
                    caught = 0;
                    shipSank = true;
                    break;
                }
                else if (char.IsDigit(field[currentRow, currentCol]))
                {
                    caught += int.Parse(field[currentRow, currentCol].ToString());
                    field[currentRow, currentCol] = 'S';
                }

                command = Console.ReadLine();
            }

            if (shipSank)
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentCol}]");
            }
            else if (caught >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - caught} tons of fish more.");
            }

            if (caught > 0)
            {
                Console.WriteLine($"Amount of fish caught: {caught} tons.");
            }

            if (!shipSank)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        Console.Write(field[row, col]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

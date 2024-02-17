using System.Data.Common;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            char[,] array = new char[squareSize, squareSize];
            if (squareSize < 3)
            {
                Console.WriteLine(0);
            }

            int counter = 0;
            for (int i = 0; i < squareSize; i++)
            {
                string currentRow = Console.ReadLine();
                for (int j = 0; j < squareSize; j++)
                {
                    array[i, j] = currentRow[j];
                }
            }
            while (true)
            {
                int Counter = 0;
                int row = 0;
                int col = 0;
                for (int i = 0; i < squareSize; i++)
                {
                    for (int j = 0; j < squareSize; j++)
                    {

                        if (array[i, j] == 'K')
                        {
                            int maxCounter = 0;
                            if (j + 2 < squareSize && i + 1 < squareSize)
                            {
                                if (array[i + 1, j + 2] == 'K')
                                {
                                    maxCounter++;

                                }
                            }
                            if (j + 2 < squareSize && i - 1 >= 0)
                            {
                                if (array[i - 1, j + 2] == 'K')
                                {
                                    maxCounter++;

                                }
                            }

                            if (j - 2 >= 0 && i + 1 < squareSize)
                            {
                                if (array[i + 1, j - 2] == 'K')
                                {
                                    maxCounter++;

                                }
                            }

                            if (j - 2 >= 0 && i - 1 >= 0)
                            {
                                if (array[i - 1, j - 2] == 'K')
                                {
                                    maxCounter++;

                                }
                            }
                            if (i + 2 < squareSize && j + 1 < squareSize)
                            {
                                if (array[i + 2, j + 1] == 'K')
                                {
                                    maxCounter++;

                                }
                            }
                            if (i + 2 < squareSize && j - 1 >= 0)
                            {
                                if (array[i + 2, j - 1] == 'K')
                                {
                                    maxCounter++;

                                }
                            }


                            if (i - 2 >= 0 && j + 1 < squareSize)
                            {
                                if (array[i - 2, j + 1] == 'K')
                                {
                                    maxCounter++;

                                }
                            }
                            if (i - 2 >= 0 && j - 1 >= 0)
                            {
                                if (array[i - 2, j - 1] == 'K')
                                {
                                    maxCounter++;

                                }
                            }

                            if (maxCounter > Counter)
                            {
                                Counter = maxCounter;
                                row = i;
                                col = j;
                            }
                        }

                    }
                }
                if (Counter == 0)
                {
                    break;
                }
                else
                {

                    array[row, col] = '0';
                    counter++;

                }
            }
            Console.WriteLine(counter);
        }
    }
}

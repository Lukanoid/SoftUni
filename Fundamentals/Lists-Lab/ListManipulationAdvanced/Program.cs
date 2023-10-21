using System.ComponentModel;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool flag = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();

                if (command[0] == "Contains")
                {
                    int number = int.Parse(command[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (command[0] == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (command[0] == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNumbers.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (command[0] == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {
                    if (command[1] == "<")
                    {
                        int number = int.Parse(command[2]); // 21
                        List<int> result = new List<int>(); // 5 5

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                result.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (command[1] == ">")
                    {
                        int number = int.Parse(command[2]);
                        List<int> result = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                result.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (command[1] == ">=")
                    {
                        int number = int.Parse(command[2]);
                        List<int> result = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                result.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (command[1] == "<=")
                    {
                        int number = int.Parse(command[2]);
                        List<int> result = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                result.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", result));
                    }

                }
                else if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                    flag = true;
                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    numbers.Remove(number);
                    flag = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    int number = int.Parse(command[1]);
                    numbers.RemoveAt(number);
                    flag = true;
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }


        }


    }
}
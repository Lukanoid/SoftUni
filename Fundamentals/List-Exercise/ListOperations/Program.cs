namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    int element = int.Parse(command[1]);
                    numbers.Add(element);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, element);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int temp = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(temp);
                    }
                }
                else if (command[1] == "right")
                {
                    int count = int.Parse(command[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int last = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, last);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

    }
}
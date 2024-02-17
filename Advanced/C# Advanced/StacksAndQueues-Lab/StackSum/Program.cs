namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in input)
            {
                numbers.Push(number);
            }


            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }
                string[] data = command.Split();

                if (data[0] == "add")
                {
                    numbers.Push(int.Parse(data[1]));
                    numbers.Push(int.Parse(data[2]));
                }
                else
                {
                    int n = int.Parse(data[1]);
                    if (numbers.Count < n)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            int sum = numbers.ToArray().Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

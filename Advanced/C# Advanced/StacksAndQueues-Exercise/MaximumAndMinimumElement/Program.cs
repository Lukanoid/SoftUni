namespace MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInteractions = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfInteractions; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (command[0] == "2")
                {
                    stack.Pop();
                }
                else if (command[0] == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));

        }
    }
}

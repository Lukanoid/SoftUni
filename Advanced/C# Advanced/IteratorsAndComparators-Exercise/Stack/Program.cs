namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { ",", " " };
            int[] pushCommand = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Skip(1).ToArray();

            CustomStack<int> stack = new CustomStack<int>(pushCommand.ToList());

            string command;

            
            while ((command = Console.ReadLine()) != "END")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Push":
                        stack.Push(int.Parse(data[1]));
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System.Reflection.Metadata;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Stack<string> stack = new Stack<string>();

            foreach (var item in expression)
            {
                stack.Push(item);
            }

            int sum = 0;

            while (stack.Count > 1)
            {
                int leftNumber = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int rightNumber = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    stack.Push((leftNumber + rightNumber).ToString());
                }
                else if (sign == "-")
                {
                    stack.Push((leftNumber - rightNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}

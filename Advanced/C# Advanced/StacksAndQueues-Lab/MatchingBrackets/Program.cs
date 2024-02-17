using System.Runtime.InteropServices.ComTypes;

namespace MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int start = brackets.Pop();
                    int end = i;
                    
                    string subString = expression.Substring(start, end - start + 1);
                    Console.WriteLine(subString);
                }

            }

        }

    }
}

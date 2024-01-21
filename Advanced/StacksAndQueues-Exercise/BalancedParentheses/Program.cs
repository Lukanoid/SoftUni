namespace BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sequence = Console.ReadLine().ToCharArray();

            if (sequence.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> charStack = new Stack<char>();

            foreach (var character in sequence)
            {
                if ("{[(".Contains(character))
                {
                    charStack.Push(character);
                }
                else if (character == ')' && charStack.Peek() == '(')
                {
                    charStack.Pop();
                }
                else if (character == ']' && charStack.Peek() == '[')
                {
                    charStack.Pop();
                }
                else if (character == '}' && charStack.Peek() == '{')
                {
                    charStack.Pop();
                }
            }

            if (charStack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

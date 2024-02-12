namespace ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<string> print = str => Console.WriteLine(str);

            input.ForEach(print);
        }
    }
}

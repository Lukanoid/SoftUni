namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            List<int> secondList = new List<int>();

            foreach (string number in input)
            {
                secondList.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            }

            Console.WriteLine(string.Join(" ", secondList));
        }
    }
}
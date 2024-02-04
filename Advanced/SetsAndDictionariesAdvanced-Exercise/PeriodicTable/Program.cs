namespace PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var chemical in chemicals)
                {
                    elements.Add(chemical);
                }
            }

            Console.WriteLine(string.Join(" ",elements));
        }
    }
}

namespace UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}

namespace RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());
            HashSet<string> allNames = new HashSet<string>();

            for (int i = 0; i < names; i++)
            {
                string currentName = Console.ReadLine();
                allNames.Add(currentName);
            }

            foreach (var name in allNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
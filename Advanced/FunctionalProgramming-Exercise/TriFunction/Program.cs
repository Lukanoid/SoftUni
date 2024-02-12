using System.Reflection.Metadata.Ecma335;

namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> lenghtChecker = (currentName, lenght) =>
            {
                int sum = 0;

                for (int i = 0; i < currentName.Length; i++)
                {
                    sum += currentName[i];
                }

                if (sum >= lenght)
                {
                    return true;
                }

                return false;
            };



            foreach (var name in names)
            {

                if (lenghtChecker(name, lenght))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}

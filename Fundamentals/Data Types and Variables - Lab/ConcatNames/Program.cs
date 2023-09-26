namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a  = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine($"{a}{c}{b}");
        }
    }
}
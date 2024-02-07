using System.ComponentModel;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Directory.GetFiles(@"..\..\..\");
            Console.WriteLine(string.Join(Environment.NewLine, a));
        }
    }
}

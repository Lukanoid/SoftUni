using System.Text;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            int explosionPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    explosionPower += int.Parse(input[i + 1].ToString());
                    output.Append(input[i]);
                }
                else if (explosionPower > 0)
                {
                    explosionPower--;
                }
                else
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}
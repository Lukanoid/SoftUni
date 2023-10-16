namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = RaisedToPower(a, b);
            Console.WriteLine(result);

        }

        static double RaisedToPower(double a, double b)
        {
            double result = default;

            result = Math.Pow(a, b);

            return result;
        }
    }
}
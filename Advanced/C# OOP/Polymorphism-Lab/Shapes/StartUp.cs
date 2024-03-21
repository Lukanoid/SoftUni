namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.WriteLine(circle.CalculateArea());
        }
    }
}

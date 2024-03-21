namespace Shapes;

public class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; private set; }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string Draw()
    {
        string className = GetType().Name;
        return base.Draw() + className;
    }
}
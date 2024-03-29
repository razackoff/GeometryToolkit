namespace GeometryToolkit;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));

        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

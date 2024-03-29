namespace GeometryToolkit;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("Треугольник с такими сторонами не существует.");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double GetArea()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }
    
    public bool IsRegularTriangle()
    {
        return _sideA == _sideB && _sideA == _sideC && _sideB == _sideC;
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
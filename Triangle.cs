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

    public double CalculateArea()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }
    
    public bool IsRightTriangle()
    {
        double maxSide = Math.Max(_sideA, Math.Max(_sideB, _sideC));
        double sumOfSquares = Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2);
        double maxSideSquare = Math.Pow(maxSide, 2);
        
        return Math.Abs(maxSideSquare - (sumOfSquares - maxSideSquare)) < 1e-10;
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            return false;
        
        return a + b > c && a + c > b && b + c > a;
    }
}
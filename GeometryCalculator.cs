namespace GeometryToolkit;

public class GeometryCalculator
{
    public double CalculateArea(IShape shape)
    {
        if (shape == null)
            throw new ArgumentNullException(nameof(shape), "Фигура не может быть null.");

        return shape.GetArea();
    }
}
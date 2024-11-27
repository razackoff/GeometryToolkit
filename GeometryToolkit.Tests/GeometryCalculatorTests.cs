using Xunit;

namespace GeometryToolkit.Tests;

public class GeometryCalculatorTests
{
    [Fact]
    public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var calculator = new GeometryCalculator();
        
        double expectedArea = 6;
        double actualArea = calculator.CalculateArea(triangle);

        Assert.Equal(expectedArea, actualArea, precision: 5);
    }

    [Fact]
    public void CalculateArea_ValidCircle_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        var calculator = new GeometryCalculator();

        double expectedArea = Math.PI * 25;
        double actualArea = calculator.CalculateArea(circle);

        Assert.Equal(expectedArea, actualArea, precision: 5);
    }

    [Fact]
    public void CalculateArea_NullShape_ThrowsArgumentNullException()
    {
        var calculator = new GeometryCalculator();

        Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(null));
    }
}
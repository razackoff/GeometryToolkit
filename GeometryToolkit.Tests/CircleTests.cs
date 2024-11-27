using Xunit;

namespace GeometryToolkit.Tests;

public class CircleTests
{
    [Fact]
    public void Constructor_ValidRadius_CreatesCircle()
    {
        var circle = new Circle(5);

        Assert.NotNull(circle);
    }

    [Fact]
    public void Constructor_InvalidRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        double expectedArea = Math.PI * 25;

        Assert.Equal(expectedArea, circle.CalculateArea(), precision: 5);
    }
}
using Xunit;

namespace GeometryToolkit.Tests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ValidSides_CreatesTriangle()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.NotNull(triangle);
    }

    [Fact]
    public void Constructor_InvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
    }

    [Fact]
    public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;

        Assert.Equal(expectedArea, triangle.CalculateArea(), precision: 5);
    }

    [Fact]
    public void IsRightTriangle_RightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(3, 4, 6);

        Assert.False(triangle.IsRightTriangle());
    }
}
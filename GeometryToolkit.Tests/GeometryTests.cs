using Xunit;

namespace GeometryToolkit.Tests;

public class GeometryTests
{
    [Fact]
    public void CircleAreaCalculation()
    {
        double radius = 5;
        Circle circle = new Circle(radius);

        double area = circle.GetArea();

        Assert.Equal(Math.PI * radius * radius, area);
    }

    [Fact]
    public void TriangleAreaCalculation()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        double area = triangle.GetArea();

        Assert.Equal(6, area);
    }

    [Fact]
    public void IsRegularTriangle_NotRegularTriangle_ReturnsFalse()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5; 
        
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool isRegular = triangle.IsRegularTriangle();

        Assert.False(isRegular);
    }

    [Fact]
    public void IsRegularTriangle_RegularTriangle_ReturnsTrue()
    {
        double sideA = 3;
        double sideB = 3;
        double sideC = 3;
        
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool isRegular = triangle.IsRegularTriangle();
        
        Assert.True(isRegular);
    }
}
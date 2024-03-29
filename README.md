# Документация проекта GeometryToolkit

## Описание проекта:

GeometryToolkit - это проект на C#, содержащий классы для основных геометрических фигур и вспомогательный класс для вычисления их площадей.

Пространства имен:

GeometryToolkit: содержит основные классы фигур (Circle и Triangle) и интерфейс IShape.
GeometryToolkit.Tests: содержит модульные тесты для классов фигур с использованием фреймворка Xunit.
Интерфейсы:

IShape: Определяет один метод GetArea(), который вычисляет площадь фигуры.
Классы:

Circle:

Представляет окружность и не наследуется от других классов.
Имеет приватное поле _radius для хранения радиуса окружности.
Конструктор Circle(double radius) принимает радиус в качестве входных данных и выдает ArgumentException, если радиус не является положительным.
Метод GetArea() вычисляет и возвращает площадь окружности по формуле PI * radius * radius.
Triangle:

Представляет треугольник и не наследуется от других классов.
Имеет три приватных поля: _sideA, _sideB и _sideC для хранения длин сторон треугольника.
Конструктор Triangle(double sideA, double sideB, double sideC) принимает длины трех сторон в качестве входных данных и выдает ArgumentException, если предоставленные длины сторон не могут образовать валидный треугольник.
Метод GetArea() вычисляет и возвращает площадь треугольника по формуле Герона.
Метод IsRegularTriangle() проверяет, равны ли все три стороны треугольника, и возвращает true, если это правильный треугольник, otherwise false.
Вспомогательный метод IsValidTriangle(double a, double b, double c) проверяет, удовлетворяют ли заданные длины сторон теореме о неравенстве треугольника.
Тестирование:

Пространство имен GeometryToolkit.Tests содержит модульные тесты для классов Circle и Triangle с использованием фреймворка Xunit. Эти тесты проверяют функциональность метода GetArea() и метода IsRegularTriangle() класса Triangle.

Пример использования:

\```

using GeometryToolkit;

public static void Main(string[] args)
{
    // Create a circle with radius 5
    Circle circle = new Circle(5);

    // Get the area of the circle
    double circleArea = circle.GetArea();

    // Create a triangle with sides 3, 4, and 5
    Triangle triangle = new Triangle(3, 4, 5);

    // Get the area of the triangle
    double triangleArea = triangle.GetArea();

    Console.WriteLine($"Circle area: {circleArea}");
    Console.WriteLine($"Triangle area: {triangleArea}");
}

\```

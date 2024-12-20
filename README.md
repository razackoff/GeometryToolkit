# Документация проекта GeometryToolkit

## Описание проекта:

  GeometryToolkit - это проект на C#, содержащий классы для основных геометрических фигур и вспомогательный класс для вычисления их площадей.

### Пространства имен:

  GeometryToolkit: содержит основные классы фигур (Circle и Triangle) и интерфейс IShape.
GeometryToolkit.Tests: содержит модульные тесты для классов фигур с использованием фреймворка Xunit.

### Интерфейсы:

- #### IShape: 

  Определяет один метод CalculateArea(), который вычисляет площадь фигуры.

### Классы:

- #### Circle:

  Представляет окружность и не наследуется от других классов.
Имеет приватное поле _radius для хранения радиуса окружности.
Конструктор Circle(double radius) принимает радиус в качестве входных данных и выдает ArgumentException, если радиус не является положительным.
Метод CalculateArea() вычисляет и возвращает площадь окружности по формуле PI * radius * radius.

- #### Triangle:

  Представляет треугольник и не наследуется от других классов.
Имеет три приватных поля: _sideA, _sideB и _sideC для хранения длин сторон треугольника.
Конструктор Triangle(double sideA, double sideB, double sideC) принимает длины трех сторон в качестве входных данных и выдает ArgumentException, если предоставленные длины сторон не могут образовать валидный треугольник.
Метод CalculateArea() вычисляет и возвращает площадь треугольника по формуле Герона.
Метод IsRightTriangle() проверяет, равны ли все три стороны треугольника, и возвращает true, если это правильный треугольник, otherwise false.
Вспомогательный метод IsValidTriangle(double a, double b, double c) проверяет, удовлетворяют ли заданные длины сторон теореме о неравенстве треугольника.

- #### GeometryCalculator:

  Класс GeometryCalculator предоставляет метод для вычисления площади произвольной фигуры, реализующей интерфейс IShape.

### Тестирование:

Пространство имен GeometryToolkit.Tests содержит модульные тесты для классов Circle и Triangle с использованием фреймворка Xunit. Эти тесты проверяют функциональность метода CalculateArea() и метода IsRightTriangle() класса Triangle.

### Пример использования:

```csharp

using GeometryToolkit;

public static void Main(string[] args)
{
    var circle = new Circle(5);
    var triangle = new Triangle(3, 4, 5);
    
    var calculator = new GeometryCalculator();
    
    var circleArea = calculator.CalculateArea(circle);
    var triangleArea = calculator.CalculateArea(triangle);
    
    Console.WriteLine($"Площадь круга: {circleArea}");
    Console.WriteLine($"Площадь треугольника: {triangleArea}");
}

```

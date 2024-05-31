// See https://aka.ms/new-console-template for more information
using ShapeAreaCalculator;
using ShapeAreaCalculator.Shapes;

var service = new AreaCalculatorService();

var triangle = new Triangle(4, 4, 7);
var circle = new Circle(4);

Console.WriteLine($"Area of triangle is {service.Calculate(triangle)}");
Console.WriteLine($"Area of circle is {service.Calculate(circle)}");
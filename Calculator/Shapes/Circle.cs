using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes;

public class Circle : IShape
{
    public string Name { get; } = default!;
    public double Radius { get; } = default!;

    private Circle() { }
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Value can't be less than or equals to 0");

        Name = nameof(Circle);

        Radius = radius;
    }
}
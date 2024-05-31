using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes;

public class Triangle : IShape
{
    public string Name { get; } = default!;
    public bool IsRightAngled { get; } = default!;
    public double A { get; } = default!;
    public double B { get; } = default!;
    public double C { get; } = default!;

    private Triangle() { }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Value can't be less than or equals to 0");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new InvalidOperationException("Such a triangle does not exist");

        Name = nameof(Triangle);
        IsRightAngled =
            (a * a + b * b).Equals(c * c) ||
            (a * a + c * c).Equals(b * b) ||
            (c * c + b * b).Equals(a * a);

        (A, B, C) = (a, b, c);
    }
}
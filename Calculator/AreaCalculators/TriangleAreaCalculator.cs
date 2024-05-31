using ShapeAreaCalculator.Interfaces;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.AreaCalculators;

internal sealed class TriangleAreaCalculator : IAreaCalculator<Triangle>
{
    public double Calculate(Triangle shape)
    {
        var p = GetSemiPerimeter(shape.A, shape.B, shape.C);

        return Math.Sqrt(p * (p - shape.A) * (p - shape.B) * (p - shape.C));
    }

    private double GetSemiPerimeter(double a, double b, double c) =>
        (a + b + c) / 2;
}
using ShapeAreaCalculator.Interfaces;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.AreaCalculators;

internal sealed class CircleAreaCalculator : IAreaCalculator<Circle>
{
    public double Calculate(Circle shape) =>
        Math.PI * shape.Radius * shape.Radius;
}
namespace ShapeAreaCalculator.Interfaces;

public interface IAreaCalculator<in T> where T : IShape
{
    double Calculate(T shape);
}
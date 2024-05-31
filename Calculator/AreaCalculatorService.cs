using System.Reflection;

using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator;

public sealed class AreaCalculatorService
{
    public double Calculate(IShape shape, Assembly? assembly = null)
    {
        assembly ??= Assembly.GetExecutingAssembly();

        var calculatorType = GetCalculatorType(shape.GetType(), assembly);

        var calculatorInstance = Activator.CreateInstance(calculatorType)
            ?? throw new ArgumentNullException($"Cant create instance of {calculatorType.Name}");

        var method = GetCalculatorMethod(calculatorType);

        return Convert.ToDouble(method!.Invoke(calculatorInstance, [shape]));
    }

    private Type GetCalculatorType(Type shapeType, Assembly assembly)
    {
        return assembly.GetTypes()
            .FirstOrDefault(t =>
                t.IsClass &&
                !t.IsAbstract &&
                t.GetInterfaces()
                    .Any(i =>
                        i.IsGenericType &&
                        i.GetGenericTypeDefinition().Equals(typeof(IAreaCalculator<>)) &&
                        i.GenericTypeArguments[0].Equals(shapeType)))
            ?? throw new NotImplementedException($"Calculator for type {shapeType.Name} not implemented");
    }

    private MethodInfo? GetCalculatorMethod(Type calculatorType)
    {
        return calculatorType.GetMethod(nameof(Calculate))
            ?? throw new ArgumentNullException($"Cant get Calculate method from {calculatorType.Name}");
    }
}
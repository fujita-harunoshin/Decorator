namespace Decorator;

internal class ConcreteDecoratorA(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}

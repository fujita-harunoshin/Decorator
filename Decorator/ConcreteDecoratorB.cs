namespace Decorator;

internal class ConcreteDecoratorB(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}

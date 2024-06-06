namespace Decorator;

internal abstract class Decorator(Component component) : Component
{
    protected Component _component = component;

    public void SetComponent(Component component)
    {
        _component = component;
    }

    public override string Operation()
    {
        if (_component != null)
        {
            return _component.Operation();
        }
        else
        {
            return string.Empty;
        }
    }
}

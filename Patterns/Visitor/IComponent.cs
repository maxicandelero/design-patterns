namespace design_patterns.Patterns.Visitor
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.
    public interface IComponent
    {
        string Accept(IVisitor visitor);
    }
}
namespace design_patterns.Patterns.FactoryMethod
{
    // The Logger interface declares the Log operation that all concrete classes
    // must implement.
    public interface ILogger
    {
        string Log(string message);
    }
}
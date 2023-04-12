namespace design_patterns.Patterns.FactoryMethod
{
    public class ConsoleLogger : ILogger
    {
        public string Log(string message)
        {
            return $"Console log: { message }";;
        }
    }
}
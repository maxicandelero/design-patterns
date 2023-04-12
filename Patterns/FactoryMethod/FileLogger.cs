namespace design_patterns.Patterns.FactoryMethod
{
    public class FileLogger : ILogger
    {
        public string Log(string message)
        {
            return $"File log: { message }";
        }
    }
}
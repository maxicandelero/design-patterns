namespace design_patterns.Patterns.FactoryMethod
{
    // Concrete FileLoggerFactory override the factory method in order to change the
    // resulting logger's type.
    public class ConsoleLoggerFactory : LoggerFactory
    {
        // Note that the signature of the method still uses the abstract logger
        // type, even though the concrete looger is actually returned from the
        // method. This way the FileLoggerFactory can stay independent of concrete Logger
        // classes.
        public override ILogger FactoryMethod()
        {
            return new ConsoleLogger();
        }
    }
}
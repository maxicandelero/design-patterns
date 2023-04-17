namespace design_patterns.Patterns.Decorator
{
    // The base Component interface defines operations that can be altered by
    // decorators.
    public abstract class BaseService
    {
        public abstract string Operation();
    }
}
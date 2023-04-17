namespace design_patterns.Patterns.Decorator
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class ConcreteService : BaseService
    {
        public override string Operation()
        {
            return "Some business logic";
        }
    }
}
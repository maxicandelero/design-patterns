namespace design_patterns.Patterns.FactoryMethod
{
    // The LoggerFactory class declares the factory method that is supposed to return
    // an object of a Logger class. The LoggerFactory's subclasses usually provide
    // the implementation of this method.
    public abstract class LoggerFactory
    {
        // Note that the LoggerFactory may also provide some default implementation of
        // the factory method.
        public abstract ILogger FactoryMethod();

        // Also note that, despite its name, the LoggerFactory's primary
        // responsibility is not creating the necessary instance. Usually, it contains some
        // core business logic that relies on Logger objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string Log(string message)
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            return product.Log(message);
        }
    }
}
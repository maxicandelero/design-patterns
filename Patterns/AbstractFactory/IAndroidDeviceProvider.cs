namespace design_patterns.Patterns.AbstractFactory
{
    // Each distinct product of a product family should have a base interface.
    // All variants of the product must implement this interface.
    public interface IAndroidDeviceProvider
    {
        string Settings { get; }

        // The product is able to do its own thing...
        string UsefulFunctionInAndroid();

        // ...but it also can collaborate with other products.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string UsefulFunctionInAndroid(IDeviceProviderSettings settings);
    }
}
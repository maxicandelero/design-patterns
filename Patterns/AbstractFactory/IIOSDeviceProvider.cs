namespace design_patterns.Patterns.AbstractFactory
{
    // Here's the base interface of another product. All products can
    // interact with each other, but proper interaction is possible only between
    // products of the same concrete variant.
    public interface IIOSDeviceProvider
    {
        string Settings { get; }
        
        // The product is able to do its own thing...
        string UsefulFunctionInIOS();

        // ...but it also can collaborate with other products.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string UsefulFunctionInIOS(IDeviceProviderSettings settings);
    }
}
namespace design_patterns.Patterns.AbstractFactory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    public class LocalDeviceProviderFactory : IDeviceProviderFactory
    {
        public IAndroidDeviceProvider CreateAndroidDeviceProvider()
        {
            return new LocalAndroidDeviceProvider();
        }

        public IIOSDeviceProvider CreateIOSDeviceProvider()
        {
            return new LocalIOSDeviceProvider();
        }

        public IDeviceProviderSettings CreateDeviceProviderSettings()
        {
            return new LocalDeviceProviderSettings();
        }
    }
}
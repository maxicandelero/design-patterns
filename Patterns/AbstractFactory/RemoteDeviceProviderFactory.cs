namespace design_patterns.Patterns.AbstractFactory
{
    public class RemoteDeviceProviderFactory : IDeviceProviderFactory
    {
        // Each Concrete Factory has a corresponding product variant.
        public IAndroidDeviceProvider CreateAndroidDeviceProvider()
        {
            return new RemoteAndroidDeviceProvider();
        }

        public IIOSDeviceProvider CreateIOSDeviceProvider()
        {
            return new RemoteIOSDeviceProvider();
        }

        public IDeviceProviderSettings CreateDeviceProviderSettings()
        {
            return new RemoteDeviceProviderSettings();
        }
    }
}
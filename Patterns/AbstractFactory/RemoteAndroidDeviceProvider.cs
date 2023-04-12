namespace design_patterns.Patterns.AbstractFactory
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class RemoteAndroidDeviceProvider : IAndroidDeviceProvider
    {
        public string Settings { get; private set; } = "Default";

        public string UsefulFunctionInAndroid()
        {
            return $"Android device is running in Remote mode. Settings: { Settings }.";
        }

        public string UsefulFunctionInAndroid(IDeviceProviderSettings settings)
        {
            Settings = settings.GetDeviceProviderSettings();

            return $"Android device is running in Remote mode. Settings: { Settings }.";
        }
    }
}
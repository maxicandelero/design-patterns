namespace design_patterns.Patterns.AbstractFactory
{
    public class RemoteIOSDeviceProvider : IIOSDeviceProvider
    {
        public string Settings { get; private set; } = "Default";

        public string UsefulFunctionInIOS()
        {
            return $"iOS device is running in Remote mode. Settings: { Settings }.";
        }

        public string UsefulFunctionInIOS(IDeviceProviderSettings settings)
        {
            Settings = settings.GetDeviceProviderSettings();

            return $"iOS device is running in Remote mode. Settings: { Settings }.";
        }
    }
}
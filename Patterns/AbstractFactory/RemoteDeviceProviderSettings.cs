namespace design_patterns.Patterns.AbstractFactory
{
    public class RemoteDeviceProviderSettings : IDeviceProviderSettings
    {
        public string GetDeviceProviderSettings()
        {
            return "Remote custom settings";
        }
    }
}
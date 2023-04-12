namespace design_patterns.Patterns.AbstractFactory
{
    public class LocalDeviceProviderSettings : IDeviceProviderSettings 
    {
        public string GetDeviceProviderSettings()
        {
            return "Local custom settings";
        }
    }
}
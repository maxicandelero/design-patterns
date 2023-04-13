namespace design_patterns.Patterns.Adapter
{
    // The target defines the domain-specific interface used by the client code.
    public interface IWeatherServiceAdapter
    {
        string GetTemperature(string zipCode);
    }
}
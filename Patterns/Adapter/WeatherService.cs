namespace design_patterns.Patterns.Adapter
{
    // The adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    public class WeatherService
    {
        public string GetTemperature(string cityName)
        {
            return $"Temperature in { cityName } is 28ºC";
        }
    }
}
using design_patterns.Patterns.Adapter;
using Xunit;

namespace design_patterns.Patterns.Tests.Adapter
{
    public class AdapterTest
    {
        [Fact]
        public void get_current_temperature_in_miami()
        {   
            WeatherService adaptee = new WeatherService();
            IWeatherServiceAdapter adapter = new WeatherServiceAdapter(adaptee);
            
            string temperature = adapter.GetTemperature("33101");
            
            Assert.Equal("Temperature in Miami is 28ºC", temperature);
        }
    }
}
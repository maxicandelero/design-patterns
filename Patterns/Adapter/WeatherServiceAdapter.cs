namespace design_patterns.Patterns.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class WeatherServiceAdapter : IWeatherServiceAdapter
    {
        private readonly WeatherService _adaptee;

        public WeatherServiceAdapter(WeatherService adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetTemperature(string zipCode)
        {
            //method to get cityname by zipcode 
            string cityName = getCityName(zipCode);
            
            return this._adaptee.GetTemperature(cityName);
        }

        private string getCityName(string zipCode) 
        {
            return "Miami";
        }
    }
}
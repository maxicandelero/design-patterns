namespace design_patterns.Patterns.Bridge
{
    // Each Concrete Implementation corresponds to a specific platform
    // This is going to be a class and should implement the Implementation interface
    public class SonyLedTv : ILedTv
    {
        public string SwitchOn()
        {
            return "Turning ON : Sony TV";
        }
        public string SwitchOff()
        {
            return "Turning OFF : Sony TV";
        }
        public string SetChannel(int channelNumber)
        {
            return $"Setting channel Number { channelNumber } on Sony TV";
        }
    }
}
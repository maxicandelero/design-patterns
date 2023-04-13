namespace design_patterns.Patterns.Bridge
{
    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractRemoteControl. 
    // This Redefined Abstraction Class extends the interface defined by AbstractRemoteControl class.
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILedTv ledTv) 
        {
            this.ledTv = ledTv;
        }

        public override string SwitchOn()
        {
            return ledTv.SwitchOn();
        }

        public override string SwitchOff()
        {
            return ledTv.SwitchOff();
        }

        public override string SetChannel(int channelNumber)
        {
            return ledTv.SetChannel(channelNumber);
        }
    }
}
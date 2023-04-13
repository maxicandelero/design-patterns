namespace design_patterns.Patterns.Bridge
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILedTv ledTv)
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
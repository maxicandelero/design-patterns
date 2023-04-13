namespace design_patterns.Patterns.Bridge
{
    //This is an abstract class that contains members that define an abstract business object and its functionality.
    //It contains a reference to an object of type ILEDTV and delegates all of the real work to this object.
    //It can also act as the base class for other abstractions.
    public abstract class AbstractRemoteControl
    {
        protected ILedTv ledTv;
        public abstract string SwitchOn();
        public abstract string SwitchOff();
        public abstract string SetChannel(int channelNumber);
    }
}
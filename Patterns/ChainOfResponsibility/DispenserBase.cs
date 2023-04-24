namespace design_patterns.Patterns.ChainOfResponsibility
{
    // The default chaining behavior can be implemented inside a base handler
    // class.
    public abstract class DispenserBase : IDispenseChain
    {
        protected IDispenseChain _handler;

        public IDispenseChain SetNext(IDispenseChain handler)
        {
            this._handler = handler;
            
            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // dollar50Dispenser.SetNext(dollar20Dispenser).SetNext(dollar10Dispenser);
            return handler;
        }
        
        public abstract string Dispense(Currency currency);
    }
}
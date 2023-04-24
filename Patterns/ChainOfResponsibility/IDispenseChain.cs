namespace design_patterns.Patterns.ChainOfResponsibility
{
    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    public interface IDispenseChain
    {
        IDispenseChain SetNext(IDispenseChain handler);
        
        string Dispense(Currency currency);
    }
}
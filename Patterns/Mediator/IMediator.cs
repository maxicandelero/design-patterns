namespace design_patterns.Patterns.Mediator
{
    // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.
    public interface IMediator
    {
        string Notify(object sender, string ev);
    }
}
namespace design_patterns.Patterns.State
{
    public class ConcreteStateA : State
    {
        // Concrete States implement various behaviors, associated with a state of
        // the Context.
        public override string Handle1()
        {
            this._context.TransitionTo(new ConcreteStateB());
            return "ConcreteStateA handles request1. ConcreteStateA wants to change the state of the context.";
        }

        public override string Handle2()
        {
            return "ConcreteStateA handles request2.";
        }
    }
}
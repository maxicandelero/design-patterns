namespace design_patterns.Patterns.State
{
    public class ConcreteStateB : State
    {
        public override string Handle1()
        {
            return "ConcreteStateB handles request1.";
        }

        public override string Handle2()
        {
            this._context.TransitionTo(new ConcreteStateA());
            return "ConcreteStateB handles request2. ConcreteStateB wants to change the state of the context.";
        }
    }
}
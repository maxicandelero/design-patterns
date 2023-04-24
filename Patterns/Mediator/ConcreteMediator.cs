namespace design_patterns.Patterns.Mediator
{
    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    public class ConcreteMediator : IMediator
    {
        private Component1 _component1;

        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        } 

        public string Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                return $"Mediator reacts on A and triggers folowing operations: { this._component2.DoC() }";
            }
            if (ev == "D")
            {
                return $"Mediator reacts on D and triggers following operations: { this._component1.DoB() }{ this._component2.DoC() }";
            }
            return string.Empty;
        }
    }
}
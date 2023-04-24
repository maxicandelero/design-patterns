namespace design_patterns.Patterns.Mediator
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    public class Component1 : BaseComponent
    {
        public string DoA()
        {
            return $"Component 1 does A. { this._mediator.Notify(this, "A") }";
        }

        public string DoB()
        {
            return $"Component 1 does B. { this._mediator.Notify(this, "B") }";
        }
    }
}
namespace design_patterns.Patterns.Mediator
{
    public class Component2 : BaseComponent
    {
        public string DoC()
        {
            return $"Component 2 does C. { this._mediator.Notify(this, "C") }";
        }

        public string DoD()
        {
            return $"Component 2 does D. { this._mediator.Notify(this, "D") }"; 
        }
    }
}
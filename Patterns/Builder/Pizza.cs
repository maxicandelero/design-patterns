namespace design_patterns.Patterns.Builder
{
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Pizza
    {
        private List<string> _parameters = new List<string>();
        
        public void Add(string part)
        {
            this._parameters.Add(part);
        }
        
        public string GetOrder()
        {
            var result = string.Join(",", _parameters);
            return $"Ordered pizza: { result }";
        }
    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }
}
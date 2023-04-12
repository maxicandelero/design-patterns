namespace design_patterns.Patterns.Builder
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IPizzaBuilder _builder;

        public Director(IPizzaBuilder builder)
        {
            _builder = builder;
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public Pizza BuildHamPizza(PizzaSize pizzaSize)
        {
            return this._builder.Size(pizzaSize).AddSauce().AddCheese().AddHam().Build();
        }
        
        public Pizza BuildFugazzaPizza(PizzaSize pizzaSize)
        {
            return this._builder.Size(pizzaSize).AddSauce().AddCheese().AddOnions().Build();
        }
    }
}
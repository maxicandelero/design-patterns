namespace design_patterns.Patterns.Builder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public PizzaBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._pizza = new Pizza();
        }

        public IPizzaBuilder Size(PizzaSize pizzaSize) 
        {
            this._pizza.Add(pizzaSize.ToString());
            return this;
        }
        
        // All production steps work with the same product instance.
        public IPizzaBuilder AddCheese()
        {
            this._pizza.Add("Cheese");
            return this;
        }
        
        public IPizzaBuilder AddSauce()
        {
            this._pizza.Add("Sauce");
            return this;
        }

        public IPizzaBuilder AddHam()
        {
            this._pizza.Add("Ham");
            return this;
        }
        
        public IPizzaBuilder AddOnions()
        {
            this._pizza.Add("Onions");
            return this;
        }

         public IPizzaBuilder AddOlives()
        {
            this._pizza.Add("Olives");
            return this;
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Pizza Build()
        {
            try
            {
                return this._pizza;
            }
            finally
            {
                this.Reset();
            }
        }
    }
}
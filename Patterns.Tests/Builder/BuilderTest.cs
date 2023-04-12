using design_patterns.Patterns.Builder;
using Xunit;

namespace design_patterns.Patterns.Tests.Builder
{
    public class BuilderTest
    {
        [Fact]
        public void can_be_ordered_a_custom_pizza()
        {   
            IPizzaBuilder builder = new PizzaBuilder();
            
            Pizza pizza = builder.Size(PizzaSize.Medium).AddSauce().AddCheese().AddOlives().Build();

            Assert.Equal("Ordered pizza: Medium,Sauce,Cheese,Olives", pizza.GetOrder());
        }

        [Fact]
        public void can_be_ordered_a_ham_pizza()
        {   
            IPizzaBuilder builder = new PizzaBuilder();
            var director = new Director(builder);
            
            Pizza pizza = director.BuildHamPizza(PizzaSize.Large);

            Assert.Equal("Ordered pizza: Large,Sauce,Cheese,Ham", pizza.GetOrder());
        }

        [Fact]
        public void can_be_ordered_a_fugazza_pizza()
        {   
            IPizzaBuilder builder = new PizzaBuilder();
            var director = new Director(builder);
            
            Pizza pizza = director.BuildFugazzaPizza(PizzaSize.Small);

            Assert.Equal("Ordered pizza: Small,Sauce,Cheese,Onions", pizza.GetOrder());
        }
    }
}
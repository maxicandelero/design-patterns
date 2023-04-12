namespace design_patterns.Patterns.Builder
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IPizzaBuilder
    {
        void Reset();
        IPizzaBuilder Size(PizzaSize pizzaSize);
        IPizzaBuilder AddSauce();
        IPizzaBuilder AddCheese();
        IPizzaBuilder AddHam();
        IPizzaBuilder AddOnions();
        IPizzaBuilder AddOlives();
        Pizza Build();
    }
}
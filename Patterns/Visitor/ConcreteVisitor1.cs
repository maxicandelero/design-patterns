namespace design_patterns.Patterns.Visitor
{
    // Concrete Visitors implement several versions of the same algorithm, which
    // can work with all concrete component classes.
    //
    // You can experience the biggest benefit of the Visitor pattern when using
    // it with a complex object structure, such as a Composite tree. In this
    // case, it might be helpful to store some intermediate state of the
    // algorithm while executing visitor's methods over various objects of the
    // structure.
    public class ConcreteVisitor1 : IVisitor
    {
        public string VisitConcreteComponentA(ConcreteComponentA element)
        {
            return element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1. ";
        }

        public string VisitConcreteComponentB(ConcreteComponentB element)
        {
            return element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1. ";
        }
    }
}
namespace design_patterns.Patterns.Visitor
{
    public class ConcreteVisitor2 : IVisitor
    {
        public string VisitConcreteComponentA(ConcreteComponentA element)
        {
            return element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2. ";
        }

        public string VisitConcreteComponentB(ConcreteComponentB element)
        {
            return element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2. ";
        }
    }
}
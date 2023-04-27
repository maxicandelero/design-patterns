using design_patterns.Patterns.Visitor;
using Xunit;

namespace design_patterns.Patterns.Tests.Visitor
{
    public class VisitorTest
    {
        [Fact]
        public void validate_visitor_code()
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            IVisitor visitor = new ConcreteVisitor1();

            string result = string.Empty;
            foreach (IComponent component in components)
            {
                result += component.Accept(visitor);
            }

            Assert.Equal("A + ConcreteVisitor1. B + ConcreteVisitor1. ", result);
        }
    }
}
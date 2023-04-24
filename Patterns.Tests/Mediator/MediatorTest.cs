using design_patterns.Patterns.Mediator;
using Xunit;

namespace design_patterns.Patterns.Tests.Mediator
{
    public class MediatorTest
    {
        [Fact]
        public void client_triggers_operation_A()
        {   
            var component1 = new Component1();
            var component2 = new Component2();
            var mediator = new ConcreteMediator(component1, component2);

            var result = component1.DoA();

            Assert.Equal("Component 1 does A. Mediator reacts on A and triggers folowing operations: Component 2 does C. ", result);
        }

        [Fact]
        public void client_triggers_operation_D()
        {   
            var component1 = new Component1();
            var component2 = new Component2();
            var mediator = new ConcreteMediator(component1, component2);

            var result = component2.DoD();

            Assert.Equal("Component 2 does D. Mediator reacts on D and triggers following operations: Component 1 does B. Component 2 does C. ", result);
        }
    }
}
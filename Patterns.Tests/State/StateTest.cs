using design_patterns.Patterns.State;
using Xunit;

namespace design_patterns.Patterns.Tests.State
{
    public class StateTest
    {
        [Fact]
        public void validate_the_context_state_transition()
        {
            var context = new Context(new ConcreteStateA());

            string resultRequest1 = context.Request1();
            string resultRequest2 = context.Request2();

            Assert.Equal("ConcreteStateA handles request1. ConcreteStateA wants to change the state of the context.", resultRequest1);
            Assert.Equal("ConcreteStateB handles request2. ConcreteStateB wants to change the state of the context.", resultRequest2);   
        }
    }
}
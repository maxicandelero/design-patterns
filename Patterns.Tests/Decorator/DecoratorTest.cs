using design_patterns.Patterns.Decorator;
using Xunit;

namespace design_patterns.Patterns.Tests.Decorator
{
    public class DecoratorTest
    {
        [Fact]
        public void timer_decorator_is_checking_the_time_taken_to_handle_the_request()
        {   
            var service = new ConcreteService();
            var timerDecorator = new TimerDecorator(service);

            var serviceResult = service.Operation();
            var timerDecoratorResult = timerDecorator.Operation();

            Assert.Equal("Some business logic", serviceResult);
            Assert.Contains("Time: ", timerDecoratorResult);
            Assert.Contains("Some business logic", timerDecoratorResult);
        }
    }
}
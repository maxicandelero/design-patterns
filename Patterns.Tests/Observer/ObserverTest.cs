using design_patterns.Patterns.Observer;
using Xunit;

namespace design_patterns.Patterns.Tests.Observer
{
    public class ObserverTest
    {
        [Fact]
        public void notify_to_the_correct_observer_in_some_business_logic()
        {   
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();

            subject.Attach(observerA);
            subject.Attach(observerB);

            string result = subject.SomeBusinessLogic();

            if (subject.State >= 2)
            {
                Assert.Equal("ConcreteObserverA: Nothing to do. ConcreteObserverB: Reacted to the event. ", result);
                
            }
            else if (subject.State == 0)
            {
                Assert.Equal("ConcreteObserverA: Reacted to the event. ConcreteObserverB: Reacted to the event. ", result);
            }
            else
            {
                Assert.Equal("ConcreteObserverA: Reacted to the event. ConcreteObserverB: Nothing to do. ", result);
            }
        }
    }
}
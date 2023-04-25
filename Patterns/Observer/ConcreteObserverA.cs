namespace design_patterns.Patterns.Observer
{
    public class ConcreteObserverA : IObserver
    {
        public string Update(ISubject subject)
        {            
            if ((subject as Subject).State < 2)
            {
                return "ConcreteObserverA: Reacted to the event.";
            }
            return "ConcreteObserverA: Nothing to do.";
        }
    }
}
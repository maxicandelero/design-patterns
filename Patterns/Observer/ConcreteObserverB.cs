namespace design_patterns.Patterns.Observer
{
    public class ConcreteObserverB : IObserver
    {
        public string Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                return "ConcreteObserverB: Reacted to the event.";
            }
            return "ConcreteObserverB: Nothing to do.";
        }
    }
}
namespace design_patterns.Patterns.Observer
{
    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class Subject : ISubject
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        // Trigger an update in each subscriber.
        public string Notify()
        {
            string result = string.Empty;
            foreach (var observer in _observers)
            {
                result += $"{ observer.Update(this) } " ;
            }
            return result;
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public string SomeBusinessLogic()
        {
            this.State = 2;// new Random().Next(0, 10);

            Thread.Sleep(15);

            return this.Notify();
        }
    }
}
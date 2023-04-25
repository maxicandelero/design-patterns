namespace design_patterns.Patterns.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        string Update(ISubject subject);
    }
}
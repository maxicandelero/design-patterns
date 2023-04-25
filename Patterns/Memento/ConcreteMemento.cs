namespace design_patterns.Patterns.Memento
{
    // The Concrete Memento contains the infrastructure for storing the
    // Originator's state.
    public class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return this._state;
        }
        
        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{this._date} / {this._state}";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
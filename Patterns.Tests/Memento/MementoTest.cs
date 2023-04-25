using design_patterns.Patterns.Memento;
using Xunit;

namespace design_patterns.Patterns.Tests.Memento
{
    public class MementoTest
    {
        [Fact]
        public void backup_a_new_state()
        {   
            var initialState = "InitialState";
            var originator = new Originator(initialState);
            var caretaker = new Caretaker(originator);

            caretaker.Backup();
            string newState = originator.DoSomething();
            caretaker.Backup();

            string history = caretaker.ShowHistory();

            Assert.Equal($"{ initialState } - { newState } - ", history);
        }

        [Fact]
        public void backup_a_new_state_and_then_undo_it()
        {   
            var initialState = "InitialState";
            var originator = new Originator(initialState);
            var caretaker = new Caretaker(originator);

            caretaker.Backup();
            string newState = originator.DoSomething();
            caretaker.Backup();

            caretaker.Undo();

            string history = caretaker.ShowHistory();

            Assert.Equal($"{ initialState } - ", history);
        }
    }
}
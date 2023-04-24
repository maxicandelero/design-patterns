namespace design_patterns.Patterns.Command
{
    public class FileInvoker
    {
        private ICommand _command;

        public FileInvoker(ICommand command)
        {
            this._command = command;
        }

        public string Execute()
        {
            return this._command.Execute();
        }
    }
}
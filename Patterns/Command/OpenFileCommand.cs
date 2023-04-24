namespace design_patterns.Patterns.Command
{
    public class OpenFileCommand : ICommand
    {
        private IFileSystemReceiver _fileSystem;

        public OpenFileCommand(IFileSystemReceiver fs)
        {
            this._fileSystem = fs;
        }

        public string Execute()
        {
            //open command is forwarding request to OpenFile method
            return this._fileSystem.OpenFile();
        }
    }
}
namespace design_patterns.Patterns.Command
{
    public class WriteFileCommand : ICommand
    {
        private IFileSystemReceiver _fileSystem;

        public WriteFileCommand(IFileSystemReceiver fs)
        {
            this._fileSystem = fs;
        }

        public string Execute()
        {
            return this._fileSystem.WriteFile();
        }
    }
}
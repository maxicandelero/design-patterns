namespace design_patterns.Patterns.Command
{
    public class CloseFileCommand : ICommand
    {
        private IFileSystemReceiver _fileSystem;

        public CloseFileCommand(IFileSystemReceiver fs)
        {
            this._fileSystem = fs;
        }

        public string Execute()
        {
            return this._fileSystem.CloseFile();
        }
    }
}
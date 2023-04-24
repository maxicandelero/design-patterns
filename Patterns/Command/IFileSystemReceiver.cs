namespace design_patterns.Patterns.Command
{
    public interface IFileSystemReceiver
    {
        string OpenFile();
        string WriteFile();
        string CloseFile();
    }
}
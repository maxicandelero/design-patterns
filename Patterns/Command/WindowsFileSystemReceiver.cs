namespace design_patterns.Patterns.Command
{
    public class WindowsFileSystemReceiver : IFileSystemReceiver
    {
        public string OpenFile()
        {
            return "Opening file in Windows OS";
        }

        public string WriteFile()
        {
            return "Writing file in Windows OS";
        }

        public string CloseFile()
        {
            return "Closing file in Windows OS";
        }
    }
}
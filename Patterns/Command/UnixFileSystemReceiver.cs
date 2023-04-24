namespace design_patterns.Patterns.Command
{
    public class UnixFileSystemReceiver : IFileSystemReceiver
    {
        public string OpenFile()
        {
            return "Opening file in unix OS";
        }

        public string WriteFile()
        {
            return "Writing file in unix OS";
        }

        public string CloseFile()
        {
            return "Closing file in unix OS";
        }
    }
}
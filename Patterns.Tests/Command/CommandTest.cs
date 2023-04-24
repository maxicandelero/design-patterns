using design_patterns.Patterns.Command;
using Xunit;

namespace design_patterns.Patterns.Tests.Command
{
    public class CommandTest
    {
        [Fact]
        public void execute_file_actions_in_windows_system()
        {   
            IFileSystemReceiver fileSystemReceiver = new WindowsFileSystemReceiver();
            FileInvoker fileInvoker = new FileInvoker(new OpenFileCommand(fileSystemReceiver));
            string openCommandResult = fileInvoker.Execute();
            fileInvoker = new FileInvoker(new WriteFileCommand(fileSystemReceiver));
            string writeCommandResult = fileInvoker.Execute();
            fileInvoker = new FileInvoker(new CloseFileCommand(fileSystemReceiver));
            string closeCommandResult = fileInvoker.Execute();

            Assert.Equal("Opening file in Windows OS", openCommandResult);
            Assert.Equal("Writing file in Windows OS", writeCommandResult);
            Assert.Equal("Closing file in Windows OS", closeCommandResult);
        }

        [Fact]
        public void execute_file_actions_in_unix_system()
        {   
            IFileSystemReceiver fileSystemReceiver = new UnixFileSystemReceiver();
            FileInvoker fileInvoker = new FileInvoker(new OpenFileCommand(fileSystemReceiver));
            string openCommandResult = fileInvoker.Execute();
            fileInvoker = new FileInvoker(new WriteFileCommand(fileSystemReceiver));
            string writeCommandResult = fileInvoker.Execute();
            fileInvoker = new FileInvoker(new CloseFileCommand(fileSystemReceiver));
            string closeCommandResult = fileInvoker.Execute();

            Assert.Equal("Opening file in unix OS", openCommandResult);
            Assert.Equal("Writing file in unix OS", writeCommandResult);
            Assert.Equal("Closing file in unix OS", closeCommandResult);
        }
    }
}
using design_patterns.Patterns.FactoryMethod;
using Xunit;

namespace design_patterns.Patterns.Tests.FactoryMethod
{
    public class FactoryMethodTest
    {
        [Fact]
        public void console_logger_should_log_the_message_in_the_console()
        {   
            LoggerFactory factory = new ConsoleLoggerFactory();
            
            // The client code works with an instance of a concrete logger, albeit
            // through its base interface. As long as the client keeps working with
            // the logger via the base interface, you can pass it any logger's
            // subclass.
            Assert.Equal("Console log: Hello world!", factory.Log("Hello world!"));
        }

        [Fact]
        public void file_logger_should_log_the_message_in_a_file()
        {   
            LoggerFactory factory = new FileLoggerFactory();
            
            // The client code works with an instance of a concrete logger, albeit
            // through its base interface. As long as the client keeps working with
            // the logger via the base interface, you can pass it any logger's
            // subclass.
            Assert.Equal("File log: Hello world!", factory.Log("Hello world!"));
        }
    }
}
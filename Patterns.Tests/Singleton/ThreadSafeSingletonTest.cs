using System.Collections.Concurrent;
using design_patterns.Patterns.Singleton;
using Xunit;

namespace design_patterns.Patterns.Tests.Singleton
{
    public class ThreadSafeSingletonTest
    {
        [Fact]
        public void thread_safe_singleton_works_with_the_same_instance()
        {
            Thread process1 = new Thread(() =>
            {
                ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance("FOO");
                Assert.Equal("FOO", singleton.Value);
            });
            Thread process2 = new Thread(() =>
            {
                ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance("BAR");
                // If you see here the value equal to FOO, then singleton was reused
                Assert.Equal("FOO", singleton.Value);
            });
            
            process1.Start();
            process2.Start();
            
            process1.Join();
            process2.Join();
        }
    }
}
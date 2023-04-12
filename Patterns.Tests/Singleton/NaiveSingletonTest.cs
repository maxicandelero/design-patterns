using design_patterns.Patterns.Singleton;
using Xunit;

namespace design_patterns.Patterns.Tests.Singleton
{
    public class NaiveSingletonTest
    {
        [Fact]
        public void naive_singleton_works_with_the_same_instance()
        {   
            NaiveSingleton s1 = NaiveSingleton.GetInstance();
            NaiveSingleton s2 = NaiveSingleton.GetInstance();

            // The two objects are the same instance
            Assert.Same(s1, s2);
        }
    }
}
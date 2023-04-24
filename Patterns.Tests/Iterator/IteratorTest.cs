using design_patterns.Patterns.Iterator;
using Xunit;

namespace design_patterns.Patterns.Tests.Iterator
{
    public class IteratorTest
    {
        [Fact]
        public void straight_traversal_through_collection()
        {   
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            string result = "";
            foreach (var element in collection)
            {
                result += $"{ element } ";
            }

            Assert.Equal("First Second Third ", result);
        }

        [Fact]
        public void reverse_traversal_through_collection()
        {   
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            collection.ReverseDirection();
            string result = "";
            foreach (var element in collection)
            {
                result += $"{ element } ";
            }

            Assert.Equal("Third Second First ", result);
        }
    }
}
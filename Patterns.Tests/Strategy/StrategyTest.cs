using design_patterns.Patterns.Strategy;
using Xunit;

namespace design_patterns.Patterns.Tests.Strategy
{
    public class StrategyTest
    {
        [Fact]
        public void initial_strategy_must_be_used()
        {
            var context = new StrategyContext(new InsertionSortAlgorithm());

            string result = context.DoSomeBusinessLogic();

            Assert.Equal("InsertionSortAlgorithm: Sorting data using the insertion sort algorithm", result);
        }

        [Fact]
        public void selected_strategy_must_be_used()
        {
            var context = new StrategyContext(new InsertionSortAlgorithm());
            context.SetStrategy(new QuickSortAlgorithm());

            string result = context.DoSomeBusinessLogic();

            Assert.Equal("QuickSortAlgorithm: Sorting data using the quick sort algorithm", result);
        }
    }
}
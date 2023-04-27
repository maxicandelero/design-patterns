namespace design_patterns.Patterns.Strategy
{
    // The Context defines the interface of interest to clients.
    public class StrategyContext
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private ISortingAlgorithm _strategy;

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public StrategyContext(ISortingAlgorithm strategy)
        {
            this._strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(ISortingAlgorithm strategy)
        {
            this._strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public string DoSomeBusinessLogic()
        {
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            return result;
        }
    }
}
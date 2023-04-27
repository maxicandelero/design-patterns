namespace design_patterns.Patterns.Strategy
{
    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface ISortingAlgorithm
    {
        string DoAlgorithm(object data);
    }
}
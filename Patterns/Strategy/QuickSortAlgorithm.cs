namespace design_patterns.Patterns.Strategy
{
    public class QuickSortAlgorithm : ISortingAlgorithm
    {
        public string DoAlgorithm(object data)
        {
            var result = data as List<string>;
            result.Sort();
            return "QuickSortAlgorithm: Sorting data using the quick sort algorithm";
        }
    }
}
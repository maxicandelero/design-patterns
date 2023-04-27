namespace design_patterns.Patterns.Strategy
{
    public class InsertionSortAlgorithm : ISortingAlgorithm
    {
        public string DoAlgorithm(object data)
        {
            var result = data as List<string>;
            result.Sort();
            return "InsertionSortAlgorithm: Sorting data using the insertion sort algorithm";
        }
    }
}
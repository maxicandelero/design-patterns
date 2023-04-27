namespace design_patterns.Patterns.Strategy
{
    public class HeapSortAlgorithm : ISortingAlgorithm
    {
        public string DoAlgorithm(object data)
        {
            var result = data as List<string>;
            result.Sort();
            return "HeapSortAlgorithm: Sorting data using the heap sort algorithm";
        }   
    }
}
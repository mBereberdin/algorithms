namespace SearchMachine.Services.Implementations;

using algorithms.Sorts;

using SearchMachine.Services.Interfaces;

/// <inheritdoc />
public class SortService : ISortService
{
    /// <inheritdoc />
    public IEnumerable<int> Selection(int[] unsortedData)
    {
        var sortedData = SelectionSort.Sort(unsortedData);

        return sortedData;
    }
}
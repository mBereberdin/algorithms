namespace SearchMachine.Services.Implementations;

using algorithms;

using SearchMachine.Services.Interfaces;

/// <inheritdoc />
public class SearchService : ISearchService
{
    /// <inheritdoc />
    public bool TryFindElementIndex(int[] sortedData, int elementToFind, out int elementIndex)
    {
        elementIndex = -1;

        if (!BinarySearch.TryFindElementIndex(sortedData, elementToFind, out var index))
        {
            elementIndex = index;

            return true;
        }

        return false;
    }
}
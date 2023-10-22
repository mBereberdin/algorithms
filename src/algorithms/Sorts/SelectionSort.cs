namespace algorithms.Sorts;

/// <summary>
/// Сортировка выбором.
/// </summary>
public static class SelectionSort
{
    /// <summary>
    /// Отсортировать коллекцию.
    /// </summary>
    /// <param name="unsortedData">Неотсортированная коллекция.</param>
    /// <returns>Отсортированная коллекция.</returns>
    public static IEnumerable<int> Sort(int[] unsortedData)
    {
        if (unsortedData.Length is 0)
        {
            throw new ArgumentException("Невозможно отсортировать пустую коллекцию.");
        }

        var sortedData = Array.Empty<int>();

        for (var indexSortedData = 0; indexSortedData < unsortedData.Length; indexSortedData += 1)
        {
            var min = int.MaxValue;
            var minCount = 0;

            for (var indexUnsortedData = 0; indexUnsortedData < unsortedData.Length; indexUnsortedData += 1)
            {
                var currentElement = unsortedData[indexUnsortedData];
                if (min > currentElement && !sortedData.Contains(currentElement))
                {
                    min = currentElement;
                    minCount = 1;

                    continue;
                }

                if (min == currentElement)
                {
                    minCount += 1;
                }
            }

            var minArray = Enumerable.Repeat(min, minCount).ToArray();
            sortedData = sortedData.Concat(minArray).ToArray();
        }

        return sortedData;
    }
}
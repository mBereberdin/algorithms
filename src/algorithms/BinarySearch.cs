namespace algorithms;

/// <summary>
/// Бинарный поиск.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    /// Попытаться найти индекс элемента.
    /// </summary>
    /// <param name="sortedData">Отсортированная коллекция для поиска.</param>
    /// <param name="elementToFind">Элемент, индекс которого необходимо найти.</param>
    /// <param name="elementIndex">Индекс найденного элемента. Если элемент не найден - -1.</param>
    /// <returns>True - если удалось найти индекс элемента, иначе - false.</returns>
    public static bool TryFindElementIndex(int[] sortedData, int elementToFind, out int elementIndex)
    {
        elementIndex = -1;

        if (sortedData.Length is 0)
        {
            return false;
        }

        var leftLimit = 0;
        var rightLimit = sortedData.Length - 1;

        while (leftLimit != rightLimit)
        {
            var middleIndex = (leftLimit + rightLimit) / 2;
            var middleElement = sortedData[middleIndex];

            if (middleElement == elementToFind)
            {
                elementIndex = middleIndex;

                return true;
            }

            if (middleElement > elementToFind)
            {
                rightLimit = middleIndex - 1;
            }
            else
            {
                leftLimit = middleIndex + 1;
            }
        }

        if (sortedData[leftLimit] == elementToFind)
        {
            elementIndex = leftLimit;

            return true;
        }

        return false;
    }
}
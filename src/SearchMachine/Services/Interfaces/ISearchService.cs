namespace SearchMachine.Services.Interfaces;

/// <summary>
/// Сервис поиска.
/// </summary>
public interface ISearchService
{
    /// <summary>
    /// Попытаться найти индекс элемента.
    /// </summary>
    /// <param name="sortedData">Отсортированная коллекция для поиска.</param>
    /// <param name="elementToFind">Элемент, индекс которого необходимо найти.</param>
    /// <param name="elementIndex">Индекс найденного элемента. Если элемент не найден - -1.</param>
    /// <returns>True - если удалось найти индекс элемента, иначе - false.</returns>
    public bool TryFindElementIndex(int[] sortedData, int elementToFind, out int elementIndex);
}
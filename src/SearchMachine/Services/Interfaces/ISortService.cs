namespace SearchMachine.Services.Interfaces;

/// <summary>
/// Сервис сортировок.
/// </summary>
public interface ISortService
{
    /// <summary>
    /// Отсортировать коллекцию алгоритмом выборки.
    /// </summary>
    /// <param name="unsortedData">Неотсортированная коллекция.</param>
    /// <returns>Отсортированная коллекция.</returns>
    public IEnumerable<int> Selection(int[] unsortedData);
}
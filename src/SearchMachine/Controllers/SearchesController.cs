namespace SearchMachine.Controllers;

using Microsoft.AspNetCore.Mvc;

using SearchMachine.Services.Interfaces;

/// <summary>
/// Контроллер для обработки запросов к алгоритмам поисков.
/// </summary>
[ApiController]
[Route("[controller]")]
public class SearchesController : ControllerBase
{
    /// <inheritdoc cref="ISearchService" />
    private readonly ISearchService _searchService;

    /// <inheritdoc />
    /// <param name="searchService">Сервис поиска.</param>
    public SearchesController(ISearchService searchService)
    {
        _searchService = searchService;
    }

    /// <summary>
    /// Найти индекс элемента при помощи бинарного поиска.
    /// </summary>
    /// <param name="sortedData">Отсортированная коллекция для поиска элемента.</param>
    /// <param name="element">Элемент, который необходимо найти.</param>
    /// <returns>Индекс элемента, в формате JSON.</returns>
    /// <response code="200">Когда удалось найти элемент.</response>
    /// <response code="404">Когда не удалось найти элемент.</response>
    [HttpPost("binary/{element}")]
    public IActionResult BinarySearchElement([FromBody] int[] sortedData, int element)
    {
        if (!_searchService.TryFindElementIndex(sortedData, element, out var index))
        {
            return NotFound();
        }

        return Ok(index);
    }
}
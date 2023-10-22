namespace SearchMachine.Controllers;

using Microsoft.AspNetCore.Mvc;

using SearchMachine.Services.Interfaces;

/// <summary>
/// Контроллер для обработки запросов к алгоритмам сортировок.
/// </summary>
[ApiController]
[Route("[controller]")]
public class SortsController : ControllerBase
{
    /// <inheritdoc cref="ISortService" />
    private readonly ISortService _sortService;

    /// <inheritdoc />
    /// <param name="sortService">Сервис сортировок.</param>
    public SortsController(ISortService sortService)
    {
        _sortService = sortService;
    }

    /// <summary>
    /// Отсортировать коллекцию алгоритмом выборки.
    /// </summary>
    /// <param name="unsortedData">Неотсортированная коллекция.</param>
    /// <returns>Отсортированная коллекция в формате JSON.</returns>
    /// <response code="200">Когда удалось успешно отсортировать коллекцию.</response>
    [HttpPost("selection")]
    public IActionResult SelectionSort([FromBody] int[] unsortedData)
    {
        if (unsortedData.Length is 0)
        {
            return Ok();
        }

        var sortedData = _sortService.Selection(unsortedData);

        return Ok(sortedData);
    }
}
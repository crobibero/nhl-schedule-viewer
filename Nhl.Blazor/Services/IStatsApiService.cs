using Nhl.Blazor.Models;

namespace Nhl.Blazor.Services;

/// <summary>
/// The stats api service.
/// </summary>
public interface IStatsApiService
{
    /// <summary>
    /// Gets the list of games for the specified date.
    /// </summary>
    /// <param name="input">The date input.</param>
    /// <returns>The list of games.</returns>
    Task<IReadOnlyList<Game>> GetGamesAsync(DateTime input);
}
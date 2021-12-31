using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models;

/// <summary>
/// Date container.
/// </summary>
public class Date
{
    /// <summary>
    /// Gets or sets the list of games.
    /// </summary>
    [JsonPropertyName("games")]
    public IReadOnlyList<Game> Games { get; set; } = Array.Empty<Game>();
}
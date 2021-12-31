using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models;

/// <summary>
/// Status container.
/// </summary>
public class Status
{
    /// <summary>
    /// Gets or sets the detailed state.
    /// </summary>
    [JsonPropertyName("detailedState")]
    public string? DetailedState { get; set; }
}
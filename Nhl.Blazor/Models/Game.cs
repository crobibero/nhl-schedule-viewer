using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models;

/// <summary>
/// Game container.
/// </summary>
public class Game
{
    /// <summary>
    /// Gets or sets the game date.
    /// </summary>
    [JsonPropertyName("gameDate")]
    public DateTime? GameDate { get; set; }

    /// <summary>
    /// Gets or sets the teams.
    /// </summary>
    [JsonPropertyName("teams")]
    public GameTeams? Teams { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [JsonPropertyName("status")]
    public Status? Status { get; set; }
}
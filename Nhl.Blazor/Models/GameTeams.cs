using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Game teams container.
    /// </summary>
    public class GameTeams
    {
        /// <summary>
        /// Gets or sets the away team.
        /// </summary>
        [JsonPropertyName("away")]
        public TeamContainer? Away { get; set; }

        /// <summary>
        /// Gets or sets the home team.
        /// </summary>
        [JsonPropertyName("home")]
        public TeamContainer? Home { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Team container.
    /// </summary>
    public class TeamContainer
    {
        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        [JsonPropertyName("team")]
        public Team? Team { get; set; }

        /// <summary>
        /// Gets or sets the current score.
        /// </summary>
        [JsonPropertyName("score")]
        public int? Score { get; set; }
    }
}
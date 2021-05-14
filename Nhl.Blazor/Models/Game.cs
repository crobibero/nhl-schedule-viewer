using System;
using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Game container.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Gets or sets the game pk.
        /// </summary>
        [JsonPropertyName("gamePk")]
        public int? GamePk { get; set; }

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
        /// Gets or sets the content.
        /// </summary>
        [JsonPropertyName("content")]
        public Content? Content { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonPropertyName("status")]
        public Status? Status { get; set; }
    }
}
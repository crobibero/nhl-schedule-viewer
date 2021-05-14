using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Team.
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Gets or sets the team id.
        /// </summary>
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the team abbreviation.
        /// </summary>
        [JsonPropertyName("abbreviation")]
        public string? Abbreviation { get; set; }

        /// <summary>
        /// Gets the team image.
        /// </summary>
        [JsonIgnore]
        public string Image => $"images/{Id}.webp";
    }
}
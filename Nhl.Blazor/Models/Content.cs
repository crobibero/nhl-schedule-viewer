using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Content container.
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        [JsonPropertyName("media")]
        public MediaContainer? Media { get; set; }
    }
}
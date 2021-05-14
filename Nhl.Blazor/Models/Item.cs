using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Item container.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the playback id.
        /// </summary>
        [JsonPropertyName("mediaPlaybackId")]
        public string? MediaPlaybackId { get; set; }

        /// <summary>
        /// Gets or sets the media feed type.
        /// </summary>
        [JsonPropertyName("mediaFeedType")]
        public string? MediaFeedType { get; set; }

        /// <summary>
        /// Gets or sets the call letters.
        /// </summary>
        [JsonPropertyName("callLetters")]
        public string? CallLetters { get; set; }
    }
}
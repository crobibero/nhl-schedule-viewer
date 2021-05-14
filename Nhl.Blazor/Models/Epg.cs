using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Epg container.
    /// </summary>
    public class Epg
    {
        /// <summary>
        /// Gets or sets the epg title.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the list of epg items.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<Item> Items { get; set; } = Array.Empty<Item>();
    }
}
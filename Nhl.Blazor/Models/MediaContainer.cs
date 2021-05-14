using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Media container.
    /// </summary>
    public class MediaContainer
    {
        /// <summary>
        /// Gets or sets the list of EPG.
        /// </summary>
        [JsonPropertyName("epg")]
        public IReadOnlyList<Epg> Epg { get; set; } = Array.Empty<Epg>();
    }
}
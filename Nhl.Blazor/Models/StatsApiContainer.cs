using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nhl.Blazor.Models
{
    /// <summary>
    /// Stats api container.
    /// </summary>
    public class StatsApiContainer
    {
        /// <summary>
        /// Gets or sets the list of dates.
        /// </summary>
        [JsonPropertyName("dates")]
        public IReadOnlyList<Date> Dates { get; set; } = Array.Empty<Date>();
    }
}
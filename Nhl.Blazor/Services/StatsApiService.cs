using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Nhl.Blazor.Models;

namespace Nhl.Blazor.Services
{
    /// <inheritdoc />
    public class StatsApiService : IStatsApiService
    {
        private const string ApiEndpoint = "https://statsapi.web.nhl.com/api/v1/schedule?startDate={0}&endDate={0}&expand=schedule.teams,schedule.linescore,schedule.game.content.media.epg";
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatsApiService"/> class.
        /// </summary>
        /// <param name="httpClient">Instance of the <see cref="HttpClient"/>.</param>
        public StatsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyList<Game>> GetGamesAsync(DateTime input)
        {
            var url = string.Format(CultureInfo.InvariantCulture, ApiEndpoint, input.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            try
            {
                var container = await _httpClient.GetFromJsonAsync<StatsApiContainer>(url)
                    .ConfigureAwait(false);

                return container?.Dates[0].Games ?? Array.Empty<Game>();
            }
            catch (Exception)
            {
                return Array.Empty<Game>();
            }
        }
    }
}
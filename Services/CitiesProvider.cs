using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherBlazorPWA.DataModels;

namespace WeatherBlazorPWA.Services
{
    public class CitiesProvider
    {
        private readonly HttpClient Http;
        public CitiesProvider(HttpClient Http)
        {
            this.Http = Http;
        }

        public async Task<List<City>> GetCities(string substring)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri($"https://wft-geo-db.p.rapidapi.com/v1/geo/cities?namePrefix={substring}&countryIds=LT"),
                Method = HttpMethod.Get,
        };
            request.Headers.Add("x-rapidapi-key", "31b3c83bfemshb244a9962015d3cp12ae3fjsn2e002280263c");
            request.Headers.Add("x-rapidapi-host", "wft-geo-db.p.rapidapi.com");

            var response = await Http.SendAsync(request);
            var contentStream = await response.Content.ReadAsStreamAsync();

            using var streamReader = new StreamReader(contentStream);
            using var jsonReader = new JsonTextReader(streamReader);

            JsonSerializer serializer = new JsonSerializer();
            CitiesJsonModel cities = serializer.Deserialize<CitiesJsonModel>(jsonReader);

            return cities.data.Select(x => new City() { Title = x.city }).ToList();
        }
    }
}

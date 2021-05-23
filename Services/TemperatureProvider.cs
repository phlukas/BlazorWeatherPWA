using System.Collections.Generic;
using WeatherBlazorPWA.DataModels;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Linq;
using System;

namespace WeatherBlazorPWA.Services
{
    public class TemperatureProvider
    {
        private readonly HttpClient Http;
        public TemperatureProvider(HttpClient Http)
        {
            this.Http = Http;
        }
        public async Task<List<TemperatureData>> GetTemperature(string city)
        {
            try
            {
                string api = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid=01fe172d9156c7e0b9e95fedbcc17bd8&units=metric";
                var response = await Http.GetFromJsonAsync<TemperatureJsonModel>(api);
                return response.list.Select(x => new TemperatureData() { Date = DateTimeOffset.FromUnixTimeSeconds(x.dt).UtcDateTime, Temperature = (int)x.main.temp }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

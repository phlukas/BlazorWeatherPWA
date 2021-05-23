using System.Collections.Generic;

namespace WeatherBlazorPWA.DataModels
{
    public class OnInputChangedEventArgs
    {
        public string City { get; set; }
        public List<TemperatureData> temperatures { get; set; }
    }
}

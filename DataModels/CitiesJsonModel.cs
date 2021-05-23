using System.Collections.Generic;

namespace WeatherBlazorPWA.DataModels
{
    public class CitiesJsonModel
    {
        public List<Data> data { get; set; }
    }
    public class Data
    {
        public string city { get; set; }
    }
}

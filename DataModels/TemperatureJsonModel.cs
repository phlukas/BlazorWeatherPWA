using System.Collections.Generic;

namespace WeatherBlazorPWA.DataModels
{
    public class TemperatureJsonModel
    {
        public List<TempData> list { get; set; }
    }
    public class TempData
    {
        public int dt { get; set; }
        public Main main { get; set; }
    }
    public class Main
    {
        public float temp { get; set; }
    }
}

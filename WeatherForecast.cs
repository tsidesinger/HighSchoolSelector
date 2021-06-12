using System;

namespace HighSchoolSelector
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.55560);

        public string Summary { get; set; }
    }
}

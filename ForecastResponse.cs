using System.Text.Json.Serialization;

namespace JenaWhiteFIOWeatherApp
{
    public class ForecastResponse
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        [JsonPropertyName("daily")]
        public Daily Daily { get; set; } = new Daily();
    }
    public class Daily
    {
        [JsonPropertyName("time")]
        public List<string> Time { get; set; } = new List<string>();

        [JsonPropertyName("temperature_2m_max")]
        public List<double> Temperature_2m_Max { get; set; } = new List<double>();

        [JsonPropertyName("temperature_2m_min")]
        public List<double> Temperature_2m_Min { get; set; } = new List<double>();

        [JsonPropertyName("precipitation_sum")]
        public List<double> Precipitation_Sum { get; set; } = new List<double>();
        
       
    }

}

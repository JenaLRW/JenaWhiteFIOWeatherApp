using System.Text.Json.Serialization;


namespace JenaWhiteFIOWeatherApp
{
    public class GeocodeResult
    {
        [JsonPropertyName("results")]
        public List<GeocodeLocation> Results { get; set; } = new();
    }
    public class GeocodeLocation
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string admin1 { get; set; } = string.Empty; // This is the full state name, see geocode API documentation

        public string admin2 { get; set; } = string.Empty; //sometimes the state is in this one.
        public string country { get; set; }

        public string timezone { get; set; }  

    }
    
}

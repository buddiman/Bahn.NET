using Newtonsoft.Json;

namespace Bahn.NET.Fahrplan.Models;

public class Location
{
    [JsonProperty(PropertyName = "id")] public int Id { get; set; }
    [JsonProperty(PropertyName = "lat")] public double Lat { get; set; }
    [JsonProperty(PropertyName = "lon")] public double Lon { get; set; }
    [JsonProperty(PropertyName = "name")] public string Name { get; set; }
}
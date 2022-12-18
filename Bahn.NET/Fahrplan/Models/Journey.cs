using Newtonsoft.Json;

namespace Bahn.NET.Fahrplan.Models;

public class Journey
{
    [JsonProperty(PropertyName = "arrTime")] public string ArrTime { get; set; }
    [JsonProperty(PropertyName = "depTime")] public string DepTime { get; set; }
    [JsonProperty(PropertyName = "lat")] public string Lat { get; set; }
    [JsonProperty(PropertyName = "lon")] public string Lon { get; set; }
    [JsonProperty(PropertyName = "notes")] public List<Notes> Notes { get; set; }
    [JsonProperty(PropertyName = "operator")] public string Operator { get; set; }
    [JsonProperty(PropertyName = "stopId")] public int StopId { get; set; }
    [JsonProperty(PropertyName = "stopName")] public string StopName { get; set; }
    [JsonProperty(PropertyName = "train")] public string Train { get; set; }
    [JsonProperty(PropertyName = "type")] public string Type { get; set; }
    
}

public class Notes
{
    [JsonProperty(PropertyName = "key")] public string Key { get; set; }
    [JsonProperty(PropertyName = "priority")] public string Priority { get; set; }
    [JsonProperty(PropertyName = "text")] public string Text { get; set; }
}
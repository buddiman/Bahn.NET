using Newtonsoft.Json;

namespace Bahn.NET.Fahrplan.Models;

public class Board
{
    [JsonProperty(PropertyName = "boardId")] public int BoardId { get; set; }
    [JsonProperty(PropertyName = "dateTime")] public string DateTime { get; set; }
    [JsonProperty(PropertyName = "detailsId")] public string DetailsId { get; set; }
    [JsonProperty(PropertyName = "direction")] public string Direction { get; set; }
    [JsonProperty(PropertyName = "name")] public string Name { get; set; }
    [JsonProperty(PropertyName = "origin")] public string Origin { get; set; }
    [JsonProperty(PropertyName = "stopId")] public int StopId { get; set; }
    [JsonProperty(PropertyName = "stopName")] public string StopName { get; set; }
    [JsonProperty(PropertyName = "track")] public string Track { get; set; }
    [JsonProperty(PropertyName = "type")] public string Type { get; set; }
}
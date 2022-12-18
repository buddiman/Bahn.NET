using System.Xml.Serialization;

namespace Bahn.NET.Timetables.Models;

[XmlRoot(ElementName = "timetable")]
public class Timetable
{
    [XmlElement(ElementName = "s")] public List<Stop>? Stops { get; set; }
    [XmlElement(ElementName = "m")] public List<Message>? Messages { get; set; }

    [XmlAttribute(AttributeName = "station")]
    public string? StationName { get; set; }

    [XmlAttribute(AttributeName = "eva")] public string? Eva { get; set; }
}

public class Message
{
    [XmlAttribute(AttributeName = "id")] public string? Id { get; set; }
    [XmlElement(ElementName = "t")] public MessageType? MessageType { get; set; }
    [XmlAttribute(AttributeName = "from")] public string? ValidFrom { get; set; }
    [XmlAttribute(AttributeName = "to")] public string? ValidTo { get; set; }
    [XmlAttribute(AttributeName = "cat")] public string? Category { get; set; }
    [XmlAttribute(AttributeName = "ts")] public string? Timestamp { get; set; }
    [XmlAttribute(AttributeName = "ec")] public string? ExternalCategory { get; set; }
    [XmlAttribute(AttributeName = "elnk")] public string? ExternalLink { get; set; }
    [XmlAttribute(AttributeName = "ext")] public string? ExternalText { get; set; }
    [XmlAttribute(AttributeName = "int")] public string? InternalText { get; set; }
    [XmlAttribute(AttributeName = "o")] public string? Owner { get; set; }
    [XmlElement(ElementName = "tl")] public List<TripLabel>? TripLabels { get; set; }

    [XmlElement(ElementName = "pr")] public Priority? Priority { get; set; }
    [XmlAttribute(AttributeName = "c")] public string? Code { get; set; }
    [XmlAttribute(AttributeName = "del")] public string? Deleted { get; set; }
    [XmlAttribute(AttributeName = "dm")] public string? DistributorMessage { get; set; }
}

public class Stop
{
    [XmlElement(ElementName = "m")] public List<Message>? Messages { get; set; }
    [XmlElement(ElementName = "ar")] public Event? ArrivalEvent { get; set; }
    [XmlElement(ElementName = "dp")] public Event? DepartureEvent { get; set; }
    [XmlAttribute(AttributeName = "id")] public string? Id { get; set; }
    [XmlAttribute(AttributeName = "eva")] public string? Eva { get; set; }
    [XmlElement(ElementName = "tl")] public TripLabel? TripLabel { get; set; }
    [XmlElement(ElementName = "ref")] public TripReference? TripReference { get; set; }
    [XmlElement(ElementName = "rtr")] public ReferenceTripRelation? ReferenceTripRelation { get; set; }
    [XmlElement(ElementName = "hd")] public HistoricDelay? HistoricDelay { get; set; }
    [XmlElement(ElementName = "hpc")] public HistoricPlatformChange? HistoricPlatformChange { get; set; } // TODO
}

public class Event
{
    [XmlAttribute(AttributeName = "clt")] public string? CancellationTime { get; set; }
    [XmlAttribute(AttributeName = "cp")] public string? ChangedPlatform { get; set; }
    [XmlAttribute(AttributeName = "cpth")] public string? ChangedPath { get; set; }
    [XmlElement(ElementName = "cs")] public EventStatus? ChangedStatus { get; set; }
    [XmlAttribute(AttributeName = "ct")] public string? ChangedTime { get; set; }
    [XmlAttribute(AttributeName = "dt")] public string? DistantChange { get; set; }
    [XmlAttribute(AttributeName = "hi")] public string? Hidden { get; set; }
    [XmlAttribute(AttributeName = "l")] public string? Line { get; set; }
    [XmlElement(ElementName = "m")] public List<Message>? Messages { get; set; }
    [XmlAttribute(AttributeName = "pde")] public string? PlannedDistantEndpoint { get; set; }
    [XmlAttribute(AttributeName = "pp")] public string? PlannedPlatform { get; set; }
    [XmlAttribute(AttributeName = "ppth")] public string? PlannedPath { get; set; }
    [XmlElement(ElementName = "ps")] public EventStatus? PlannedStatus { get; set; }
    [XmlAttribute(AttributeName = "pt")] public string? PlannedTime { get; set; }
    [XmlAttribute(AttributeName = "tra")] public string? Transition { get; set; }

    [XmlAttribute(AttributeName = "wings")]
    public string? Wing { get; set; }
}

public class TripLabel
{
    [XmlAttribute(AttributeName = "f")] public string? FilterFlags { get; set; }
    [XmlElement(ElementName = "t")] public TripType? TripType { get; set; }
    [XmlAttribute(AttributeName = "o")] public string Owner { get; set; }
    [XmlAttribute(AttributeName = "c")] public string Category { get; set; }
    [XmlAttribute(AttributeName = "n")] public string TrainNumber { get; set; }
}

public class TripReference
{
    [XmlElement(ElementName = "rt")] public TripLabel? TripReferenceLabel { get; set; }
    [XmlElement(ElementName = "tl")] public TripLabel? TripLabel { get; set; }
}

public class RTL
{
    [XmlAttribute(AttributeName = "c")] public string? Category { get; set; }
    [XmlAttribute(AttributeName = "n")] public string? TrainNumber { get; set; }
}

public class ReferenceTripRelation
{
    [XmlElement(ElementName = "c")] public bool? Cancelled { get; set; }
    [XmlElement(ElementName = "ea")] public Unk1? Ea { get; set; }
    [XmlElement(ElementName = "sd")] public Unk1? Sd { get; set; }
    [XmlAttribute(AttributeName = "id")] public string? Id { get; set; }
    [XmlElement(ElementName = "rtl")] public RTL? Rtl { get; set; }
}

public class Unk1
{
    [XmlAttribute(AttributeName = "eva")] public string? Eva { get; set; }
    [XmlAttribute(AttributeName = "i")] public string? StopIndex { get; set; }
    [XmlAttribute(AttributeName = "n")] public string? ExtendedStopName { get; set; }
    [XmlAttribute(AttributeName = "pt")] public string? PlannedTime { get; set; }
}

public class HistoricDelay
{
    [XmlAttribute(AttributeName = "ar")] public string? Arrival { get; set; }
    [XmlAttribute(AttributeName = "cod")] public string? DelayCause { get; set; }
    [XmlAttribute(AttributeName = "dp")] public string? DepartureTime { get; set; }
    [XmlElement(ElementName = "src")] public DelaySource? DelaySource { get; set; }
    [XmlAttribute(AttributeName = "ts")] public string? Timestamp { get; set; }
}

public class HistoricPlatformChange
{
    [XmlAttribute(AttributeName = "ar")] public string? ArrivalPlatform { get; set; }
    [XmlAttribute(AttributeName = "cot")] public string? TrackChangeCause { get; set; }
    [XmlAttribute(AttributeName = "dp")] public string? DeparturePlatform { get; set; }
    [XmlAttribute(AttributeName = "ts")] public string? Timestamp { get; set; }
}
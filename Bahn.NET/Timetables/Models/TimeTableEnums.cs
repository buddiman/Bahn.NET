using System.Xml.Serialization;

namespace Bahn.NET.Timetables.Models;

public enum Priority
{
    [XmlEnum("1")] High,
    [XmlEnum("2")] Medium,
    [XmlEnum("3")] Low,
    [XmlEnum("4")] Done,
}

public enum DelaySource
{
    [XmlEnum("L")] Leibit,
    [XmlEnum("NA")] RisneAutIrisne,
    [XmlEnum("NM")] RisneManIrisNe,
    [XmlEnum("V")] Vdv,
    [XmlEnum("IA")] Ia,
    [XmlEnum("IM")] Im,
    [XmlEnum("A")] AutomaticPrognosis,
}

public enum ConnectionStatus
{
    [XmlEnum("w")] Waiting,
    [XmlEnum("n")] Transition,
    [XmlEnum("a")] Alternative,
}

public enum EventStatus
{
    [XmlEnum("p")] Planned,
    [XmlEnum("a")] Added,
    [XmlEnum("c")] Cancelled,
}

public enum TripType
{
    [XmlEnum("p")] p,
    [XmlEnum("e")] e,
    [XmlEnum("z")] z,
    [XmlEnum("s")] s,
    [XmlEnum("h")] h,
    [XmlEnum("n")] n,
}

public enum MessageType
{
    [XmlEnum("h")] HimAHim,
    [XmlEnum("q")] QualityChange,
    [XmlEnum("f")] FreeText,
    [XmlEnum("d")] CauseOfDelay,
    [XmlEnum("i")] Ibis,
    [XmlEnum("u")] UnassignedIbisMessage,
    [XmlEnum("r")] Disruption,
    [XmlEnum("c")] Connection,
}
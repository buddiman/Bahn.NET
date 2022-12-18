using System.Xml.Serialization;

namespace Bahn.NET.Timetables.Models
{
    [XmlRoot(ElementName = "station")]
    public class Station
    {
        [XmlAttribute(AttributeName = "p")] public string P { get; set; }
        [XmlAttribute(AttributeName = "meta")] public string Meta { get; set; }
        [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
        [XmlAttribute(AttributeName = "eva")] public string Eva { get; set; }

        [XmlAttribute(AttributeName = "ds100")]
        public string Ds100 { get; set; }

        [XmlAttribute(AttributeName = "db")] public string Db { get; set; }

        [XmlAttribute(AttributeName = "creationts")]
        public string Creationts { get; set; }
    }

    [XmlRoot(ElementName = "stations")]
    public class Stations
    {
        [XmlElement(ElementName = "station")] public Station Station { get; set; }
    }
}
using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("regionprefix")]
    public class RegionPrefix : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("dateTimeStamp")]
        public required Timestamp DateTimeStamp { get; set; }

        [XmlElement("daylightSavingEnabled")]
        public bool? DaylightSavingEnabled { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("gmt")]
        public int? Gmt { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("regionId")]
        public int? RegionId { get; set; }

        [XmlElement("regionPrefixValue")]
        public string? RegionPrefixValue { get; set; }
    }
}
using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("businesstimezone")]
    public class BusinessTimeZone : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("businesstimezone")]
        public string? BusinessTimeZoneName { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

    }
}
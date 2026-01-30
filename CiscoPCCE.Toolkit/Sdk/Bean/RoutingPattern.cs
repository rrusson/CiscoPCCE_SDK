using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("routingPattern")]
    public class RoutingPattern : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("configParam")]
        public string? ConfigParam { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("destination")]
        public string? Destination { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("pattern")]
        public string? Pattern { get; set; }

        [XmlElement("patternType")]
        public int? PatternType { get; set; }

        [XmlElement("rnaTimeout")]
        public int? RnaTimeout { get; set; }

        [XmlElement("sendToOriginator")]
        public bool? SendToOriginator { get; set; }
    }
}
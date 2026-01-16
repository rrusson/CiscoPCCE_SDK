using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("expandedCallVariable")]
    public class ExpandedCallVariable : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("bytesRequired")]
        public int? BytesRequired { get; set; }

        [XmlElement("bytesRequiredInCtiServer")]
        public int? BytesRequiredInCtiServer { get; set; }

        [XmlElement("ciscoProvided")]
        public bool? CiscoProvided { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("eccArray")]
        public bool? EccArray { get; set; }

        [XmlElement("enabled")]
        public bool? Enabled { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("maximumArraySize")]
        public int? MaximumArraySize { get; set; }

        [XmlElement("maximumLength")]
        public int? MaximumLength { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("persistent")]
        public bool? Persistent { get; set; }

    }
}
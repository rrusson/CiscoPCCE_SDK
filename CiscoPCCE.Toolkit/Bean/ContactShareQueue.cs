using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("contactShareQueue")]
    public class ContactShareQueue : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("queueType")]
        public string? QueueType { get; set; }

        [XmlElement("targetInstance")]
        public required ReferenceBean TargetInstance { get; set; }

        [XmlElement("targetInstanceId")]
        public int? TargetInstanceId { get; set; }

        [XmlElement("targetQueue")]
        public required TargetQueue TargetQueue { get; set; }
    }
}
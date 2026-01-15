using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("routingClient")]
    public class RoutingClient : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("clientType")]
        public short? ClientType { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("lateThreshold")]
        public short? LateThreshold { get; set; }

        [XmlElement("logicalController")]
        public required ReferenceBean LogicalController { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("peripheral")]
        public required PeripheralRef Peripheral { get; set; }

        [XmlElement("timeoutLimit")]
        public short? TimeoutLimit { get; set; }

        [XmlElement("timeoutThreshold")]
        public short? TimeoutThreshold { get; set; }
    }
}
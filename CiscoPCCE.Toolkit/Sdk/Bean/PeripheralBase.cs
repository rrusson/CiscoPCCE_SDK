using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deploymenttypeinfo")
    public class PeripheralBase : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("clientType")]
        public short? ClientType { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("defaultDeskSetting")]
        public required ReferenceBean DefaultDeskSetting { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("hostName1")]
        public string? HostName1 { get; set; }

        [XmlElement("hostName2")]
        public string? HostName2 { get; set; }

        [XmlElement("hostPort1")]
        public int? HostPort1 { get; set; }

        [XmlElement("hostPort2")]
        public int? HostPort2 { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("networkTarget")]
        public required ReferenceBean NetworkTarget { get; set; }

        [XmlElement("peripheralGateway")]
        public required ReferenceBean PeripheralGateway { get; set; }

        [XmlElement("peripheralName")]
        public string? PeripheralName { get; set; }

    }
}
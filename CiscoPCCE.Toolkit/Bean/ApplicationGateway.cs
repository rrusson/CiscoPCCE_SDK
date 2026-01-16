using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("applicationGateway")]
    public class ApplicationGateway : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlArray("connections")]
        [XmlArrayItem("connection")]
        public List<ApplicationGatewayConnection>? Connections { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("encryption")]
        public ApplicationGatewayEncryptionEnum Encryption { get; set; }

        [XmlElement("faultTolerance")]
        public ApplicationGatewayFaultTolerance FaultTolerance { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("preferredSide")]
        public ApplicationGatewayPreferredSide PreferredSide { get; set; }

    }
}
using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("CloudConnectSettings")]
    public class CloudConnector : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentID")]
        public string? DeploymentID { get; set; }

        [XmlElement("deploymentName")]
        public string? DeploymentName { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("proxyAddress")]
        public string? ProxyAddress { get; set; }

        [XmlElement("registrationStatus")]
        public string? RegistrationStatus { get; set; }
    }
}
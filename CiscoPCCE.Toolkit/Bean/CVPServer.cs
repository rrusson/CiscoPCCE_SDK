using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("CVP")]
    public class CVPServer : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("icm")]
        public required ICMServiceConfig Icm { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("infrastructure")]
        public required InfrastructureServiceConfig Infrastructure { get; set; }

        [XmlElement("ivr")]
        public required IVRServiceConfig Ivr { get; set; }

        [XmlElement("mediaServer")]
        public required MediaServerConfig MediaServer { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("sip")]
        public required SIPServiceConfig Sip { get; set; }

        [XmlElement("vxml")]
        public required VXMLServiceConfig Vxml { get; set; }
    }
}
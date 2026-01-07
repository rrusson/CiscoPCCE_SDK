using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("CVP")]
    public class CVPServer : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public required ICMServiceConfig Icm { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required InfrastructureServiceConfig Infrastructure { get; set; }

        public required IVRServiceConfig Ivr { get; set; }

        public required MediaServerConfig MediaServer { get; set; }

        public new string? RefURL { get; set; }

        public required SIPServiceConfig Sip { get; set; }

        public required VXMLServiceConfig Vxml { get; set; }
    }
}
using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("supervisorUserInfo")]
    public class SupervisorUserInfo : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("domainName")]
        public string? DomainName { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("ssoEnabled")]
        public bool? SsoEnabled { get; set; }

        [XmlElement("supervisor")]
        public bool? Supervisor { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}
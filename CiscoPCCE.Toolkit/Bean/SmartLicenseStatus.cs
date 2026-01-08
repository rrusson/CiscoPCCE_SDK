using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("smartLicenseStatus")]
    public class SmartLicenseStatus : BaseApiBean
    {
        [XmlElement("agentEnabled")]
        public string? AgentEnabled { get; set; }

        [XmlElement("serialNumber")]
        public string? SerialNumber { get; set; }

        [XmlElement("state")]
        public string? State { get; set; }
    }
}
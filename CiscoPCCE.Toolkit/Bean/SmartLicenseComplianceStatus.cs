using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("smartLicenseComplianceStatus")]
    public class SmartLicenseComplianceStatus : BaseApiBean
    {
        [XmlElement("complianceStatus")]
        public string? ComplianceStatus { get; set; }

        [XmlElement("smartAgentStatusList")]
        public required SmartAgentStatusList SmartAgentStatusList { get; set; }
    }
}